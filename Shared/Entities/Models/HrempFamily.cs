using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempFamily
    {
        public HrempFamily()
        {
            HrempFamilyImages = new HashSet<HrempFamilyImage>();
        }

        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Relation { get; set; }
        public string PersonName { get; set; }
        public string PassportNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public int? RelationId { get; set; }

        public virtual Account Emp { get; set; }
        public virtual Hrmaster RelationNavigation { get; set; }
        public virtual ICollection<HrempFamilyImage> HrempFamilyImages { get; set; }
    }
}
