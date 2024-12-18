using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UserRightsMaster
    {
        public UserRightsMaster()
        {
            UserRights = new HashSet<UserRight>();
            UserRightsTemplates = new HashSet<UserRightsTemplate>();
        }

        public int Id { get; set; }
        public string Keyword { get; set; }
        public string Module { get; set; }

        public virtual ICollection<UserRight> UserRights { get; set; }
        public virtual ICollection<UserRightsTemplate> UserRightsTemplates { get; set; }
    }
}
