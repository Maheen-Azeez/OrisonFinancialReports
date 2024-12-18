using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class InvoiceNote
    {
        public string Source { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
    }
}
