using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class PaymentModeMast
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? ReceiptCategoryId { get; set; }
        public int? PaymentCategoryId { get; set; }

        public virtual AccountCategoryMast PaymentCategory { get; set; }
        public virtual AccountCategoryMast ReceiptCategory { get; set; }
        public virtual SubGroupMast ReceiptCategoryNavigation { get; set; }
    }
}
