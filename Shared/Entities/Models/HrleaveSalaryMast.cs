using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrleaveSalaryMast
    {
        public HrleaveSalaryMast()
        {
            HrleaveSalaries = new HashSet<HrleaveSalary>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Vdate { get; set; }
        public decimal? Total { get; set; }
        public bool? Split { get; set; }

        public virtual ICollection<HrleaveSalary> HrleaveSalaries { get; set; }
    }
}
