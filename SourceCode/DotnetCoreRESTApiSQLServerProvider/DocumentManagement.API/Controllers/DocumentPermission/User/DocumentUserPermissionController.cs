﻿using System;
using System.Threading.Tasks;
using DocumentManagement.Data.Dto;
using DocumentManagement.MediatR.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocumentManagement.API.Controllers
{
    /// <summary>
    /// DocumentUserPermission
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocumentUserPermissionController : ControllerBase
    {
        public IMediator _mediator { get; set; }
        /// <summary>
        /// DocumentUserPermission
        /// </summary>
        /// <param name="mediator"></param>
        public DocumentUserPermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Add Document User Permission
        /// </summary>
        /// <param name="addDocumentUserPermissionCommand"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces("application/json", "application/xml", Type = typeof(DocumentUserPermissionDto))]
        public async Task<IActionResult> AddDocumentUserPermission(AddDocumentUserPermissionCommand addDocumentUserPermissionCommand)
        {
            var result = await _mediator.Send(addDocumentUserPermissionCommand);
            return StatusCode(result.StatusCode, result);
        }
        /// <summary>
        /// Delete Document User Permission By Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteDocumentUserPermission(Guid Id)
        {
            var deleteUserPermissionCommand = new DeleteDocumentUserPermissionCommand
            {
                Id = Id
            };
            var result = await _mediator.Send(deleteUserPermissionCommand);
            return StatusCode(result.StatusCode, result);
        }
    }
}
