using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempAllowanceDetail
    {
        public int Id { get; set; }
        public int Mid { get; set; }
        public int EmpD { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }

        public virtual HrempAllowanceMaster MidNavigation { get; set; }
    }
}
