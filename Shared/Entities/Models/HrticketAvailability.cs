using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrticketAvailability
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? UnPaidLeave { get; set; }
        public decimal? WorkingDays { get; set; }
        public string Ticket { get; set; }
        public decimal? AvailTicket { get; set; }
    }
}
