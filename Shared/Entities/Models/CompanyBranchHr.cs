using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CompanyBranchHr
    {
        public CompanyBranchHr()
        {
            UsersBranchesHrs = new HashSet<UsersBranchesHr>();
        }

        public int Id { get; set; }
        public string Branch { get; set; }
        public string FinBranch { get; set; }
        public int? FinBranchId { get; set; }

        public virtual Company FinBranchNavigation { get; set; }
        public virtual ICollection<UsersBranchesHr> UsersBranchesHrs { get; set; }
    }
}
