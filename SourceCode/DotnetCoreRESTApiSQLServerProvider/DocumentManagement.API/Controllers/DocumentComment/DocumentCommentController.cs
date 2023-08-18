﻿using DocumentManagement.Data.Dto;
using DocumentManagement.MediatR.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DocumentManagement.API.Controllers
{
    /// <summary>
    /// Document
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocumentCommentController : BaseController
    {
        private readonly IMediator _mediator;
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCommentController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public DocumentCommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets the Inquiry Notes .
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json", "application/xml", Type = typeof(List<DocumentCommentDto>))]
        public async Task<IActionResult> GetDocumentComment(Guid id)
        {
            var query = new GetDocumentCommentByIdQuery { DocumentId = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        /// <summary>
        /// Inserts the Document Comment
        /// </summary>
        /// <param name="addDocumentCommentCommand">The add Document Comment command.</param>
        /// <returns></returns>
        [HttpPost]
        [Produces("application/json", "application/xml", Type = typeof(DocumentCommentDto))]
        public async Task<IActionResult> AddDocumentComment([FromBody] AddDocumentCommentCommand addDocumentCommentCommand)
        {
            var result = await _mediator.Send(addDocumentCommentCommand);
            return Ok(result);
        }

        /// <summary>
        /// Deletes the Document Comment By Id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocumentComment(Guid id)
        {
            var command = new DeleteDocumentCommentCommand() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
