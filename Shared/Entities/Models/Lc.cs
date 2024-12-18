using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Lc
    {
        public long Id { get; set; }
        public string Lcnumber { get; set; }
        public string Description { get; set; }
        public string BankRefNo { get; set; }
        public int? AccountId { get; set; }
        public int? SupplierId { get; set; }
        public string Country { get; set; }
        public string LoadingPort { get; set; }
        public string DischargePort { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? Expirydate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string PaymentDays { get; set; }
        public string Pdescription { get; set; }
        public int? BankId { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public decimal? MarginAmount { get; set; }
        public string Insurance { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string Field9 { get; set; }
        public string Field10 { get; set; }

        public virtual Account Account { get; set; }
        public virtual Account Bank { get; set; }
        public virtual Account Supplier { get; set; }
    }
}
