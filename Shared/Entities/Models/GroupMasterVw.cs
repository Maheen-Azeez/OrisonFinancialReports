using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class GroupMasterVw
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public bool IsGroup { get; set; }
        public string Unit { get; set; }
        public short CategoryId { get; set; }
        public bool StockItem { get; set; }
    }
}
