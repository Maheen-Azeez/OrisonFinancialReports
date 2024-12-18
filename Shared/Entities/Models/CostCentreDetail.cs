using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CostCentreDetail
    {
        public int Ccid { get; set; }
        public string Type { get; set; }
        public string SerialNo { get; set; }
        public string RegNo { get; set; }
        public int? SupplierId { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? Sdate { get; set; }
        public string Make { get; set; }
        public string Myear { get; set; }
        public DateTime? Edate { get; set; }
        public decimal? ContractValue { get; set; }
        public decimal? InvoicedAmt { get; set; }
        public int? ClientId { get; set; }
        public int? StaffId1 { get; set; }
        public int? StaffId2 { get; set; }
        public string NvarField1 { get; set; }
        public string NvarField2 { get; set; }
        public string NvarField3 { get; set; }
        public decimal? NumField1 { get; set; }
        public decimal? NumField2 { get; set; }
        public decimal? NumField3 { get; set; }
        public bool? IsPaid { get; set; }
        public bool? WagePeriodwise { get; set; }
        public int? WageStartDay { get; set; }

        public virtual CostCentre Cc { get; set; }
        public virtual Account Client { get; set; }
        public virtual Account Supplier { get; set; }
    }
}
