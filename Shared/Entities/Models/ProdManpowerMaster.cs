using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProdManpowerMaster
    {
        public int Id { get; set; }
        public string Pcode { get; set; }
        public string Designation { get; set; }
        public decimal Rate { get; set; }
        public decimal Hours { get; set; }
        public decimal Amount { get; set; }

        public virtual ProdMaster PcodeNavigation { get; set; }
    }
}
