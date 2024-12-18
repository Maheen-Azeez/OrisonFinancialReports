using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Category
    {
        public Category()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public string Category1 { get; set; }

        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}
