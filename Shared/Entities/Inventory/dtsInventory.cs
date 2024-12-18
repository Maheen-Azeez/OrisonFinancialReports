using OrisonMIS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{
    public class dtsInventory
    {
        public dtInvVoucher voucher { get; set; }

        public dtInvVoucherAdditionals voucheradditionals { get; set; }

        public dtInvVoucherEntry[] voucherentry { get; set; }

        public dtInvTransactions[] transaction { get; set; }

        public dtInvVoucherStatus voucherStatus { get; set; }
        public int DocType { get; set; }

        public int ApprovalType { get; set; }

        public string Action { get; set; }
        public UserTrack UserTrack { get; set; }
    }
}
