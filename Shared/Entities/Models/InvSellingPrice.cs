using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class InvSellingPrice
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public decimal? SellingPrice { get; set; }
        public string Unit { get; set; }
        public int? AccountId { get; set; }
        public string Field1 { get; set; }
        public int? BranchId { get; set; }
        public int? ProjectId { get; set; }
        public int? Whid { get; set; }
    }
}
