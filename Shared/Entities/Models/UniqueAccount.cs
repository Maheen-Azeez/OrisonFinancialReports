using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UniqueAccount
    {
        public string Keyword { get; set; }
        public int? AccId { get; set; }

        public virtual Account Acc { get; set; }
    }
}
