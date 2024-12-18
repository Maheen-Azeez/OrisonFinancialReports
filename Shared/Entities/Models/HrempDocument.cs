using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempDocument
    {
        public HrempDocument()
        {
            HrempDocImages = new HashSet<HrempDocImage>();
            HrempExpImages = new HashSet<HrempExpImage>();
            HrempFamImages = new HashSet<HrempFamImage>();
            HrempQualImages = new HashSet<HrempQualImage>();
        }

        public int Id { get; set; }
        public string DocumentType { get; set; }
        public int EmpId { get; set; }
        public string DocumentNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuePlace { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string EduLevel { get; set; }
        public int? Passyear { get; set; }
        public string Institution { get; set; }

        public virtual Account Emp { get; set; }
        public virtual ICollection<HrempDocImage> HrempDocImages { get; set; }
        public virtual ICollection<HrempExpImage> HrempExpImages { get; set; }
        public virtual ICollection<HrempFamImage> HrempFamImages { get; set; }
        public virtual ICollection<HrempQualImage> HrempQualImages { get; set; }
    }
}
