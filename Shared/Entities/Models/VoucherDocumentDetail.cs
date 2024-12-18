using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherDocumentDetail
    {
        public int Id { get; set; }
        public int Did { get; set; }
        public string LocalPath { get; set; }
        public string OriginalLocation { get; set; }

        public virtual VoucherDocumentMaster DidNavigation { get; set; }
    }
}
