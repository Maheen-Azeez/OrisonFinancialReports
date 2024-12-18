using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class User
    {
        public User()
        {
            AccountsListUsers = new HashSet<AccountsListUser>();
            DcsdocumentsTracks = new HashSet<DcsdocumentsTrack>();
            DcsuserSecurities = new HashSet<DcsuserSecurity>();
            UserRights = new HashSet<UserRight>();
            UsersBranches = new HashSet<UsersBranch>();
            UsersBranchesHrs = new HashSet<UsersBranchesHr>();
            UsersSections = new HashSet<UsersSection>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Category { get; set; }
        public string Section { get; set; }
        public string Status { get; set; }
        public int? Accountid { get; set; }

        public virtual ICollection<AccountsListUser> AccountsListUsers { get; set; }
        public virtual ICollection<DcsdocumentsTrack> DcsdocumentsTracks { get; set; }
        public virtual ICollection<DcsuserSecurity> DcsuserSecurities { get; set; }
        public virtual ICollection<UserRight> UserRights { get; set; }
        public virtual ICollection<UsersBranch> UsersBranches { get; set; }
        public virtual ICollection<UsersBranchesHr> UsersBranchesHrs { get; set; }
        public virtual ICollection<UsersSection> UsersSections { get; set; }
    }
}
