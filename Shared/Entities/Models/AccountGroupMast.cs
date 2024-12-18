using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AccountGroupMast
    {
        public AccountGroupMast()
        {
            Accounts = new HashSet<Account>();
            SubGroupLists = new HashSet<SubGroupList>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int OrderNo { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<SubGroupList> SubGroupLists { get; set; }
    }
}
