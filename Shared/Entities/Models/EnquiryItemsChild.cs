using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EnquiryItemsChild
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string Stock { get; set; }
        public string Remarks { get; set; }

        public virtual EnquiryItemsParent Parent { get; set; }
    }
}
