using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrgratuityAndLeaveSalaryTran
    {
        public int Id { get; set; }
        public int Glid { get; set; }
        public int EmpId { get; set; }
        public decimal? BasicSalary { get; set; }
        public int? Leaves { get; set; }
        public decimal? Gratuity { get; set; }
        public decimal? LeaveSalary { get; set; }
        public decimal? Ticket { get; set; }
        public decimal Total { get; set; }
        public long? PostId { get; set; }
        public decimal? Insurance { get; set; }

        public virtual Account Emp { get; set; }
        public virtual HrgratuityAndLeaveSalaryMaster Gl { get; set; }
        public virtual Voucher Post { get; set; }
    }
}
