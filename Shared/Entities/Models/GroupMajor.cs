using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class GroupMajor
    {
        public GroupMajor()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public string MajorGroup { get; set; }

        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}
