using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AccountsList
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountsListMast List { get; set; }
    }
}
