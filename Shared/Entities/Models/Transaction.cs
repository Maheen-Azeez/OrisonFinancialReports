using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            InverseRef = new HashSet<Transaction>();
            ProductionSubDetails = new HashSet<ProductionSubDetail>();
            TranCostCentres = new HashSet<TranCostCentre>();
        }

        public long Id { get; set; }
        public long Vid { get; set; }
        public decimal? SlNo { get; set; }
        public int ItemId { get; set; }
        public string Qty { get; set; }
        public string Focqty { get; set; }
        public decimal? Rate { get; set; }
        public string Unit { get; set; }
        public decimal? Factor { get; set; }
        public bool? IsComplex { get; set; }
        public int? Whid { get; set; }
        public long? ParentId { get; set; }
        public long? RefId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ExpDate { get; set; }
        public string Description { get; set; }
        public decimal? Addition { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Cbm { get; set; }
        public bool? Active { get; set; }
        public decimal? BasicQty { get; set; }
        public short? RowType { get; set; }
        public short? InvoiceType { get; set; }
        public bool IsReturn { get; set; }
        public long? AvgCostId { get; set; }
        public int? DrAccountId { get; set; }
        public int? CrAccountId { get; set; }
        public int? PostAccountId { get; set; }
        public int? MgntId { get; set; }
        public string TempQty { get; set; }
        public string TempUnit { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public string VarField3 { get; set; }
        public decimal? NumField1 { get; set; }
        public decimal? NumField2 { get; set; }
        public decimal? NumField3 { get; set; }
        public string TbarCode { get; set; }
        public decimal? AvgCost { get; set; }
        public decimal? LastRate { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Excise { get; set; }
        public decimal? Vatper { get; set; }
        public decimal? ExcisePer { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vrate { get; set; }
        public bool? Vatrefundable { get; set; }
        public string Vatpurpose { get; set; }
        public decimal? VatperItem { get; set; }
        public decimal? Profit { get; set; }

        public virtual AvgCost AvgCostNavigation { get; set; }
        public virtual Account CrAccount { get; set; }
        public virtual Account DrAccount { get; set; }
        public virtual ItemMaster Item { get; set; }
        public virtual Account PostAccount { get; set; }
        public virtual Transaction Ref { get; set; }
        public virtual UnitMaster UnitNavigation { get; set; }
        public virtual Voucher VidNavigation { get; set; }
        public virtual WareHouseMaster Wh { get; set; }
        public virtual ICollection<Transaction> InverseRef { get; set; }
        public virtual ICollection<ProductionSubDetail> ProductionSubDetails { get; set; }
        public virtual ICollection<TranCostCentre> TranCostCentres { get; set; }
    }
}
