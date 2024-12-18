using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherDocumentMaster
    {
        public VoucherDocumentMaster()
        {
            VoucherDocumentDetails = new HashSet<VoucherDocumentDetail>();
        }

        public int Id { get; set; }
        public long Vid { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
        public int? Credit { get; set; }
        public int? Debit { get; set; }

        public virtual Voucher VidNavigation { get; set; }
        public virtual ICollection<VoucherDocumentDetail> VoucherDocumentDetails { get; set; }
    }
}
