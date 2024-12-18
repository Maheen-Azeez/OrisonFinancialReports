using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrmaster
    {
        public Hrmaster()
        {
            HrempFamilies = new HashSet<HrempFamily>();
            HrempQualifications = new HashSet<HrempQualification>();
        }

        public int Id { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }

        public virtual ICollection<HrempFamily> HrempFamilies { get; set; }
        public virtual ICollection<HrempQualification> HrempQualifications { get; set; }
    }
}
