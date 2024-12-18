using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempDocumentsExpense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int EmpId { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string InvoiceNo { get; set; }

        public virtual Account Emp { get; set; }
    }
}
