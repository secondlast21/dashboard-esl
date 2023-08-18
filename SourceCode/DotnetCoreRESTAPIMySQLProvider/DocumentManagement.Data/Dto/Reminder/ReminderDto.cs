﻿using System;
using System.Collections.Generic;

namespace DocumentManagement.Data.Dto
{
    public class ReminderDto
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public Frequency? Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsRepeated { get; set; }
        public DayOfWeek? DayOfWeek { get; set; }
        public bool IsEmailNotification { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? DocumentId { get; set; }
        public string DocumentName { get; set; }
        public ICollection<ReminderUserDto> ReminderUsers { get; set; }
        public ICollection<DailyReminderDto> DailyReminders { get; set; }
        public ICollection<QuarterlyReminderDto> QuarterlyReminders { get; set; }
        public ICollection<HalfYearlyReminderDto> HalfYearlyReminders { get; set; }
    }
}
