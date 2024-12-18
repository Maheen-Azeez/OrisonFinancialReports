using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EssadvanceRequest
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? Date { get; set; }
        public int? Installment { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
