using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UsersSection
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Section { get; set; }
        public bool Permission { get; set; }

        public virtual UsersSectionMaster SectionNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
