﻿using System;

namespace DocumentManagement.Data.Entities
{
    public class NLog
    {
        public Guid Id { get; set; }
        public string MachineName { get; set; }
        public string Logged { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Properties { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }
    }
}
