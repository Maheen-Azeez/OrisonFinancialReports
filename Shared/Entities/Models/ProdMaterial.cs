using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProdMaterial
    {
        public int Id { get; set; }
        public string Pcode { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }

        public virtual ItemMaster Item { get; set; }
        public virtual ProdMaster PcodeNavigation { get; set; }
    }
}
