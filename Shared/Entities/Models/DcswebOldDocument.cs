using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebOldDocument
    {
        public long Id { get; set; }
        public long? FolderId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Size { get; set; }
        public decimal? Version { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUser { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Client { get; set; }
        public long? DocNo { get; set; }
        public int? VerifiedUser { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public long? DocumentId { get; set; }

        public virtual DcswebDocument Document { get; set; }
    }
}
