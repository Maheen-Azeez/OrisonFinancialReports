using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UsersBranchesHr
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public int? BranchId { get; set; }
        public bool? Permission { get; set; }

        public virtual CompanyBranchHr Branch { get; set; }
        public virtual User User { get; set; }
    }
}
