﻿using AutoMapper;
using DocumentManagement.Common.UnitOfWork;
using DocumentManagement.Data;
using DocumentManagement.Data.Dto;
using DocumentManagement.Domain;
using DocumentManagement.Helper;
using DocumentManagement.MediatR.Commands;
using DocumentManagement.Repository;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DocumentManagement.MediatR.Handlers
{
    public class UploadNewDocumentVersionCommandHandler : IRequestHandler<UploadNewDocumentVersionCommand, ServiceResponse<DocumentVersionDto>>
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IDocumentVersionRepository _documentVersionRepository;
        private readonly IUnitOfWork<DocumentContext> _uow;
        private readonly IMapper _mapper;
        private readonly ILogger<UploadNewDocumentVersionCommandHandler> _logger;
        private readonly UserInfoToken _userInfoToken;
        public UploadNewDocumentVersionCommandHandler(
            IDocumentRepository documentRepository,
            IDocumentVersionRepository documentVersionRepository,
            IUnitOfWork<DocumentContext> uow,
            IMapper mapper,
            ILogger<UploadNewDocumentVersionCommandHandler> logger,
            UserInfoToken userInfoToken)
        {
            _documentRepository = documentRepository;
            _documentVersionRepository = documentVersionRepository;
            _uow = uow;
            _mapper = mapper;
            _logger = logger;
            _userInfoToken = userInfoToken;
        }
        public async Task<ServiceResponse<DocumentVersionDto>> Handle(UploadNewDocumentVersionCommand request, CancellationToken cancellationToken)
        {
            var doc = await _documentRepository.FindAsync(request.DocumentId);
            if (doc == null)
            {
                _logger.LogError("Document Not Found");
                return ServiceResponse<DocumentVersionDto>.Return500();
            }

            var version = new DocumentVersion
            {
                Url = doc.Url,
                DocumentId = doc.Id,
                CreatedBy = doc.CreatedBy,
                CreatedDate = doc.CreatedDate,
                ModifiedBy = doc.ModifiedBy,
                ModifiedDate = doc.ModifiedDate,
            };
            doc.Url = request.Url;
            doc.CreatedDate = DateTime.UtcNow;
            doc.CreatedBy = Guid.Parse(_userInfoToken.Id);
            

            _documentRepository.Update(doc);
            _documentVersionRepository.Add(version);
            if (await _uow.SaveAsync() <= 0)
            {
                _logger.LogError("Error while adding industry");
                return ServiceResponse<DocumentVersionDto>.Return500();
            }
            var documentCommentDto = _mapper.Map<DocumentVersionDto>(version);
            return ServiceResponse<DocumentVersionDto>.ReturnResultWith200(documentCommentDto);
        }
    }
}
