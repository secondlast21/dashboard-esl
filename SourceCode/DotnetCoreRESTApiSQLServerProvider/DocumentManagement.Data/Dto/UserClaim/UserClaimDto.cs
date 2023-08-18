﻿using System;

namespace DocumentManagement.Data.Dto
{
    public class UserClaimDto : ErrorStatusCode
    {
        public Guid? UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public Guid OperationId { get; set; }
        public Guid ScreenId { get; set; }
    }
}
