using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class MasterMisc
    {
        public MasterMisc()
        {
            HrempWagesDeductions = new HashSet<HrempWagesDeduction>();
        }

        public int Id { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public bool Vdefault { get; set; }
        public int? Priority { get; set; }
        public bool? AllowDelete { get; set; }

        public virtual ICollection<HrempWagesDeduction> HrempWagesDeductions { get; set; }
    }
}
