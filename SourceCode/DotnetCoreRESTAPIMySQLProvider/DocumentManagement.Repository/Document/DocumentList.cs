﻿using DocumentManagement.Data.Dto;
using DocumentManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Repository
{
    public class DocumentList : List<DocumentDto>
    {
        public DocumentList()
        {
        }
        public int Skip { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }

        public DocumentList(List<DocumentDto> items, int count, int skip, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            Skip = skip;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        public async Task<DocumentList> Create(IQueryable<Document> source, int skip, int pageSize)
        {
            var count = await GetCount(source);
            var dtoList = await GetDtos(source, skip, pageSize);
            var dtoPageList = new DocumentList(dtoList, count, skip, pageSize);
            return dtoPageList;
        }

        public async Task<DocumentList> CreateDocumentLibrary(IQueryable<Document> source, int skip, int pageSize)
        {
            var count = await GetCount(source);
            var dtoList = await GetDocumentLibraryDtos(source, skip, pageSize);
            var dtoPageList = new DocumentList(dtoList, count, skip, pageSize);
            return dtoPageList;
        }

        public async Task<int> GetCount(IQueryable<Document> source)
        {
            return await source.AsNoTracking().CountAsync();
        }

        public async Task<List<DocumentDto>> GetDtos(IQueryable<Document> source, int skip, int pageSize)
        {
            var entities = await source
                .Skip(skip)
                .Take(pageSize)
                .AsNoTracking()
                .Select(c => new DocumentDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    CreatedDate = c.CreatedDate,
                    CategoryId = c.CategoryId,
                    Description = c.Description,
                    CategoryName = c.Category.Name,
                    Url = c.Url,
                    CreatedBy = c.User != null ? $"{c.User.FirstName} {c.User.LastName}" : "",
                    IsAllowDownload = true

                })
                .ToListAsync();
            return entities;
        }

        public async Task<List<DocumentDto>> GetDocumentLibraryDtos(IQueryable<Document> source, int skip, int pageSize)
        {
            var entities = await source
                .Skip(skip)
                .Take(pageSize)
                .AsNoTracking()
                .Select(c => new DocumentDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    CreatedDate = c.CreatedDate,
                    CategoryId = c.CategoryId,
                    Description = c.Description,
                    CategoryName = c.Category.Name,
                    CreatedBy = c.User != null ? $"{c.User.FirstName} {c.User.LastName}" : "",
                    ExpiredDate = c.GetDoucmentExpiredDate(),
                    Url = c.Url,

                })
                .ToListAsync();
            return entities;
        }
    }
}
