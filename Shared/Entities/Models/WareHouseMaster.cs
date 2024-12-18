using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class WareHouseMaster
    {
        public WareHouseMaster()
        {
            Transactions = new HashSet<Transaction>();
            VoucherAdditionals = new HashSet<VoucherAdditional>();
            WarehouseBranches = new HashSet<WarehouseBranch>();
        }

        public int Id { get; set; }
        public string Whcode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<VoucherAdditional> VoucherAdditionals { get; set; }
        public virtual ICollection<WarehouseBranch> WarehouseBranches { get; set; }
    }
}
