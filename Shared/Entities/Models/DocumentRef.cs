using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DocumentRef
    {
        public long Id { get; set; }
        public long Vid { get; set; }
        public long RefVid { get; set; }

        public virtual Voucher VidNavigation { get; set; }
    }
}
