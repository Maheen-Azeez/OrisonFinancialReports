using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebMailAttachment
    {
        public int Id { get; set; }
        public int? MailId { get; set; }
        public int? DocumentId { get; set; }
    }
}
