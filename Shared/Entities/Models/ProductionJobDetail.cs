using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProductionJobDetail
    {
        public int Id { get; set; }
        public string JobOrderNo { get; set; }
        public string CompanyName { get; set; }
        public string FactoryOrderNo { get; set; }
        public string RefNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
