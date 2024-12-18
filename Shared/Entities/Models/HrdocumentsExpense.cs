using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdocumentsExpense
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string RefNo { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public int EmpId { get; set; }
        public DateTime? LabourCard { get; set; }
        public DateTime? Visa { get; set; }
        public decimal? Amount { get; set; }

        public virtual Account Emp { get; set; }
    }
}
