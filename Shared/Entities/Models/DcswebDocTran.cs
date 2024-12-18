using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebDocTran
    {
        public int DocTransId { get; set; }
        public int MailId { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public int? Status { get; set; }
        public string Flag { get; set; }
    }
}
