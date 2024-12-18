using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemCategoryAccount
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? PurchaseAccountId { get; set; }
        public int? SalesAccountId { get; set; }
        public int? CostAccountId { get; set; }
        public int? InvAccountId { get; set; }
    }
}
