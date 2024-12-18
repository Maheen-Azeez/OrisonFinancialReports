using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class GroupParent
    {
        public int AccountId { get; set; }
        public int ParentId { get; set; }
        public int GroupLevel { get; set; }

        public virtual Account Account { get; set; }
    }
}
