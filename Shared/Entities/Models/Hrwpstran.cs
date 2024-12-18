using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrwpstran
    {
        public int Id { get; set; }
        public int Wpsid { get; set; }
        public int EmpId { get; set; }
        public decimal? TotalDays { get; set; }
        public decimal WorkedDays { get; set; }
        public decimal LeaveDays { get; set; }
        public decimal FixedIncome { get; set; }
        public decimal VariableIncome { get; set; }
        public decimal? Cash { get; set; }
        public decimal? NetPay { get; set; }

        public virtual Account Emp { get; set; }
        public virtual Hrwpsmaster Wps { get; set; }
    }
}
