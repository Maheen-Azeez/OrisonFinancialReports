using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class WarehouseBranch
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int Whid { get; set; }
        public bool Active { get; set; }
        public bool IsDefault { get; set; }

        public virtual Company Branch { get; set; }
        public virtual WareHouseMaster Wh { get; set; }
    }
}
