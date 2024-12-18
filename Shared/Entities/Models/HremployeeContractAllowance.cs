using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HremployeeContractAllowance
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public int AllowanceId { get; set; }
        public decimal? Amount { get; set; }
    }
}
