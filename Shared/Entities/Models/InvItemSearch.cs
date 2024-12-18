using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class InvItemSearch
    {
        public long Id { get; set; }
        public int ItemId { get; set; }
        public string Keyword { get; set; }
        public string KeyType { get; set; }

        public virtual ItemMaster Item { get; set; }
    }
}
