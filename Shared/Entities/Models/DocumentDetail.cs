using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DocumentDetail
    {
        public DocumentDetail()
        {
            AttachedFiles = new HashSet<AttachedFile>();
        }

        public int Id { get; set; }
        public string SlNo { get; set; }
        public string ProjectName { get; set; }
        public string Remarks { get; set; }
        public string Supplier { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public DateTime Mdate { get; set; }
        public string RefNo { get; set; }

        public virtual ICollection<AttachedFile> AttachedFiles { get; set; }
    }
}
