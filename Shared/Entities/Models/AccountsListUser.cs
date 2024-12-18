﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AccountsListUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string List { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountsListMast ListNavigation { get; set; }
        public virtual User User { get; set; }
    }
}