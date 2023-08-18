﻿using MediatR;
using System;
using System.Collections.Generic;

namespace DocumentManagement.MediatR.Commands
{
    public class DocumentPermissionUserRoleCommand : IRequest<bool>
    {
        public List<string> Roles { get; set; }
        public List<string> Users { get; set; }
        public List<string> Documents { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsAllowDownload { get; set; }
        public bool IsTimeBound { get; set; }
    }
}
