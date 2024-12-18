using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrcompDocument
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public string Type { get; set; }
        public string DocumentNo { get; set; }
        public string IssuePlace { get; set; }
        public string Category { get; set; }
        public string DocLocation { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Company { get; set; }

        public virtual HrbranchSetting CidNavigation { get; set; }
    }
}
