using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EssapproverTran
    {
        public int Id { get; set; }
        public int Amid { get; set; }
        public int? EmpId { get; set; }
        public int? ApproverId { get; set; }

        public virtual EssapproverMaster Am { get; set; }
        public virtual Account Emp { get; set; }
    }
}
