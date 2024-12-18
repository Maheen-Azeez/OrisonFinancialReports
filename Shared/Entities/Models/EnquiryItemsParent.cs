using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EnquiryItemsParent
    {
        public EnquiryItemsParent()
        {
            EnquiryItemsChildren = new HashSet<EnquiryItemsChild>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public string Date { get; set; }

        public virtual ICollection<EnquiryItemsChild> EnquiryItemsChildren { get; set; }
    }
}
