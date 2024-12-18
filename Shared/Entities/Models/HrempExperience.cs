using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempExperience
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Designation { get; set; }
        public int? DesignationId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual MastDesignation DesignationNavigation { get; set; }
        public virtual Account Emp { get; set; }
    }
}
