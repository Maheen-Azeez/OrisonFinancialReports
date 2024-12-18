using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmonthlyStaffdetail
    {
        public HrmonthlyStaffdetail()
        {
            Hrmonthlysalarydetails = new HashSet<Hrmonthlysalarydetail>();
        }

        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? Eos { get; set; }
        public string Category { get; set; }
        public int? Designation { get; set; }
        public string Status { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? Basic { get; set; }
        public string Month { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<Hrmonthlysalarydetail> Hrmonthlysalarydetails { get; set; }
    }
}
