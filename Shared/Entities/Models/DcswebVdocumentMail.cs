using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebVdocumentMail
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public string RefNo { get; set; }
        public string RegNo { get; set; }
        public int DocId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
    }
}
