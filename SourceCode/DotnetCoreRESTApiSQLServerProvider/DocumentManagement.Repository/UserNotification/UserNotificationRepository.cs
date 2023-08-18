﻿using DocumentManagement.Common.GenericRepository;
using DocumentManagement.Common.UnitOfWork;
using DocumentManagement.Data;
using DocumentManagement.Data.Dto;
using DocumentManagement.Data.Resources;
using DocumentManagement.Domain;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Repository
{
    public class UserNotificationRepository : GenericRepository<UserNotification, DocumentContext>,
       IUserNotificationRepository
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IPropertyMappingService _propertyMappingService;
        private readonly UserInfoToken _userInfoToken;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IConnectionMappingRepository _userInfoInMemory;
        private readonly IHubContext<UserHub, IHubClient> _hubContext;
        public UserNotificationRepository(
            IDocumentRepository documentRepository,
            IUserRoleRepository userRoleRepository,
            IPropertyMappingService propertyMappingService,
            UserInfoToken userInfoToken,
            IUnitOfWork<DocumentContext> uow,
            IConnectionMappingRepository userInfoInMemory,
             IHubContext<UserHub, IHubClient> hubContext) : base(uow)
        {
            _documentRepository = documentRepository;
            _userRoleRepository = userRoleRepository;
            _propertyMappingService = propertyMappingService;
            _userInfoToken = userInfoToken;
            _userInfoInMemory = userInfoInMemory;
            _hubContext = hubContext;
        }

        public void CreateUsersDocumentNotifiction(List<Guid> userIds, Guid documentId)
        {
            userIds.ForEach(userId =>
            {
                Add(new UserNotification
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    DocumentId = documentId
                });
            });
        }

        public void AddUserNotificationByReminderScheduler(ReminderScheduler reminderScheduler)
        {
            Add(new UserNotification
            {
                Id = Guid.NewGuid(),
                UserId = reminderScheduler.UserId,
                DocumentId = reminderScheduler.DocumentId,
                Message = reminderScheduler.Subject,
                IsRead = false
            });
        }


        public async Task<List<Guid>> CreateRolesDocumentNotifiction(List<Guid> roleIds, Guid documentId)
        {
            var userIds = _userRoleRepository.All.Where(cs => roleIds.Contains(cs.RoleId)).Select(c => c.UserId).Distinct().ToList();
            var document = await _documentRepository.FindAsync(documentId);
            userIds.ForEach(userId =>
            {
                Add(new UserNotification
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    DocumentId = documentId
                });

            });
            return userIds;
        }

        public async Task<NotificationList> GetUserNotifications(NotificationResource documentResource)
        {
            var collectionBeforePaging = AllIncluding(d => d.Document).Where(c => c.UserId == Guid.Parse(_userInfoToken.Id));
            collectionBeforePaging =
               collectionBeforePaging.ApplySort(documentResource.OrderBy,
               _propertyMappingService.GetPropertyMapping<UserNotificationDto, UserNotification>());

            if (!string.IsNullOrWhiteSpace(documentResource.Name))
            {
                collectionBeforePaging = collectionBeforePaging
                    .Where(c => EF.Functions.Like(c.Document.Name, $"%{documentResource.Name}%")
                    || EF.Functions.Like(c.Message, $"%{documentResource.Name}%"));
            }

            var documentAuditTrailList = new NotificationList();
            return await documentAuditTrailList.Create(
                collectionBeforePaging,
                documentResource.Skip,
                documentResource.PageSize
                );
        }

        public async Task MarkAsRead(Guid notificationId)
        {
            var notification = Find(notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
                Update(notification);
                await _uow.SaveAsync();
            }
        }

        public async Task SendNotification(List<Guid> userIds)
        {
            foreach (var userId in userIds)
            {
                await SendNotification(userId);
            }
        }

        public async Task SendNotification(Guid userId)
        {
            var userInfoReciever = _userInfoInMemory.GetUserInfoById(userId);
            if (userInfoReciever != null)
                await _hubContext.Clients.Client(userInfoReciever.ConnectionId).SendNotification(userId);
        }

        public async Task MarkAllAsRead()
        {
            var userId = Guid.Parse(_userInfoToken.Id);
            var notifications = All.Where(c => c.UserId == userId).ToList();
            notifications.ForEach(notification => notification.IsRead = true);
            UpdateRange(notifications);
            await _uow.SaveAsync();
        }

        public async Task MarkAsReadByDocumentId(Guid documentId)
        {
            var userId = Guid.Parse(_userInfoToken.Id);
            var notifications = All.Where(c => c.DocumentId == documentId && c.UserId == userId).ToList();
            notifications.ForEach(c => c.IsRead = true);
            UpdateRange(notifications);
            await _uow.SaveAsync();
        }
    }
}
