using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Essmaintenance
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? EmpId { get; set; }
        public string RefNo { get; set; }
        public DateTime Date { get; set; }
        public string BuildingName { get; set; }
        public string FlatNo { get; set; }
        public string Area { get; set; }
        public string ReportedBy { get; set; }
        public string Issue { get; set; }
        public string ActionTaken { get; set; }
        public int? ActionBy { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Status { get; set; }
        public decimal? Amount { get; set; }
        public int? Approver { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public DateTime? Date1 { get; set; }

        public virtual Account Emp { get; set; }
    }
}
