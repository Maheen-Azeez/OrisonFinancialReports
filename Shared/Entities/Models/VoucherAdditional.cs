using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherAdditional
    {
        public long Vid { get; set; }
        public string Keyword { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public bool? Vdefault { get; set; }
        public int? DiscountId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? AmountPaid { get; set; }
        public string PartyName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string HeaderText { get; set; }
        public string FooterText { get; set; }
        public int? ProjectId { get; set; }
        public int? CostPhaseId { get; set; }
        public int? CostUnitId { get; set; }
        public int? DefaultWhid { get; set; }
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
        public int? CostPhaseIdto { get; set; }
        public int? CostUnitIdto { get; set; }
        public int? DefaultWhidto { get; set; }
        public int? ProjectIdto { get; set; }
        public DateTime? Date2 { get; set; }
        public string Trnno { get; set; }
        public string Place { get; set; }
        public string Emirates { get; set; }
        public string Vatpurpose { get; set; }
        public string Vattype { get; set; }
        public string Taxcode { get; set; }
        public int? V { get; set; }

        public virtual WareHouseMaster DefaultWh { get; set; }
        public virtual Voucher VidNavigation { get; set; }
    }
}
