using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebDocFolder
    {
        public DcswebDocFolder()
        {
            DcswebDocuments = new HashSet<DcswebDocument>();
            DcswebReports = new HashSet<DcswebReport>();
        }

        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUser { get; set; }
        public string Parent { get; set; }
        public int? NodeLevel { get; set; }
        public long? OrganizationId { get; set; }
        public string Folderstatus { get; set; }

        public virtual DcswebProject Project { get; set; }
        public virtual ICollection<DcswebDocument> DcswebDocuments { get; set; }
        public virtual ICollection<DcswebReport> DcswebReports { get; set; }
    }
}
