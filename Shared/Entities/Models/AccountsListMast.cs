using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AccountsListMast
    {
        public AccountsListMast()
        {
            AccountsListUsers = new HashSet<AccountsListUser>();
            AccountsLists = new HashSet<AccountsList>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccountsListUser> AccountsListUsers { get; set; }
        public virtual ICollection<AccountsList> AccountsLists { get; set; }
    }
}
