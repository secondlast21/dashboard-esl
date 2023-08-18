﻿using AutoMapper;
using DocumentManagement.Data.Dto;
using DocumentManagement.MediatR.Queries;
using DocumentManagement.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DocumentManagement.MediatR.Handlers
{
    public class GetIsDownloadFlagQueryHandler : IRequestHandler<GetIsDownloadFlagQuery, bool>
    {
        private readonly IDocumentRolePermissionRepository _documentRolePermissionRepository;

        private readonly IDocumentRepository _documentRepository;
        private readonly IDocumentUserPermissionRepository _documentUserPermissionRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly UserInfoToken _userInfoToken;

        public GetIsDownloadFlagQueryHandler(IDocumentRolePermissionRepository documentRolePermissionRepository,
            IMapper mapper,
            IDocumentUserPermissionRepository documentUserPermissionRepository,
            IDocumentRepository documentRepository,
             IUserRepository userRepository,
             UserInfoToken userInfoToken)
        {
            _documentRolePermissionRepository = documentRolePermissionRepository;
            _mapper = mapper;
            _documentUserPermissionRepository = documentUserPermissionRepository;
            _documentRepository = documentRepository;
            _userInfoToken = userInfoToken;
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(GetIsDownloadFlagQuery request, CancellationToken cancellationToken)
        {
            var today = DateTime.UtcNow;
            var user = await _userRepository.AllIncluding(c => c.UserRoles).FirstOrDefaultAsync(c => c.Id == Guid.Parse(_userInfoToken.Id));
            var userRoles = user.UserRoles.Select(c => c.RoleId).ToList();
            var flag = await _documentRepository.AllIncluding(c => c.User, c => c.DocumentRolePermissions, c => c.DocumentUserPermissions)
                                        .AnyAsync(d => d.Id == request.DocumentId && (d.DocumentUserPermissions.Any(c => c.UserId == user.Id && c.IsAllowDownload && (!c.IsTimeBound || (c.IsTimeBound && c.StartDate < today && c.EndDate > today)))
                                                    || d.DocumentRolePermissions.Any(c => userRoles.Contains(c.RoleId) && c.IsAllowDownload && (!c.IsTimeBound || (c.IsTimeBound && c.StartDate < today && c.EndDate > today)))));
            return flag;
        }
    }
}
