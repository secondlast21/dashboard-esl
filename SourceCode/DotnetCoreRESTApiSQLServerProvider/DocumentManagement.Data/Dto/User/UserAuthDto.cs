﻿using System.Collections.Generic;

namespace DocumentManagement.Data.Dto
{
    public class UserAuthDto:  ErrorStatusCode
    {
        public UserAuthDto()
        {
            BearerToken = string.Empty;
        }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BearerToken { get; set; }
        public bool IsAuthenticated { get; set; }
        public List<AppClaimDto> Claims { get; set; }
    }
}
