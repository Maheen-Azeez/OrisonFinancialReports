using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class GroupDetail
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public decimal QtyPerUnit { get; set; }
        public string Type { get; set; }

        public virtual ItemMaster Group { get; set; }
        public virtual ItemMaster Item { get; set; }
    }
}
