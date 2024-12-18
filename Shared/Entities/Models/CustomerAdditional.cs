using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CustomerAdditional
    {
        public int Id { get; set; }
        public int CustId { get; set; }
        public int? BottleAvailable { get; set; }
        public int? BottleReturnable { get; set; }
        public int? BottleSold { get; set; }
        public int? CoolerAvailable { get; set; }
        public int? CoolerReturnable { get; set; }
        public int? CoolerSold { get; set; }
        public int? DispenserAvailable { get; set; }
        public int? DispenserReturnable { get; set; }
        public int? DispenserSold { get; set; }
        public string DeliveryDays { get; set; }
        public int? CoupenAvailable { get; set; }
        public decimal? OpeningBalance { get; set; }

        public virtual Account Cust { get; set; }
    }
}
