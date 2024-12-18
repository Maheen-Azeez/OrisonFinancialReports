using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempQualification
    {
        public HrempQualification()
        {
            HrempQualificationImages = new HashSet<HrempQualificationImage>();
        }

        public int Id { get; set; }
        public string Qualification { get; set; }
        public int? EmpId { get; set; }
        public int? DegreeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string University { get; set; }

        public virtual Hrmaster Degree { get; set; }
        public virtual Account Emp { get; set; }
        public virtual ICollection<HrempQualificationImage> HrempQualificationImages { get; set; }
    }
}
