using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            AdditionalCharges = new HashSet<AdditionalCharge>();
            DocumentRefs = new HashSet<DocumentRef>();
            HrempAdvanceDetails = new HashSet<HrempAdvanceDetail>();
            HrgratuityAndLeaveSalaryTrans = new HashSet<HrgratuityAndLeaveSalaryTran>();
            ProdManpowers = new HashSet<ProdManpower>();
            ProductionItemDetails = new HashSet<ProductionItemDetail>();
            Transactions = new HashSet<Transaction>();
            VoucherAllocations = new HashSet<VoucherAllocation>();
            VoucherCollections = new HashSet<VoucherCollection>();
            VoucherDocumentMasters = new HashSet<VoucherDocumentMaster>();
            VoucherEntries = new HashSet<VoucherEntry>();
            VoucherEntryDetails = new HashSet<VoucherEntryDetail>();
            VoucherStatuses = new HashSet<VoucherStatus>();
        }

        public long Id { get; set; }
        public string Vno { get; set; }
        public int? VnoInt { get; set; }
        public string RefNo { get; set; }
        public int Vtype { get; set; }
        public int BranchId { get; set; }
        public DateTime Vdate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime DueDate { get; set; }
        public string VoucherAgainst { get; set; }
        public string CommonNarration { get; set; }
        public int? Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
        public bool Posted { get; set; }
        public bool Printed { get; set; }
        public bool ReadOnly { get; set; }
        public bool Freezed { get; set; }
        public bool? IsCanceled { get; set; }
        public long? UserTrackId { get; set; }
        public string PreparedBy { get; set; }
        public int? AccountId { get; set; }
        public int? StaffId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? CanceledDate { get; set; }
        public int? CanceledUserId { get; set; }
        public string Remark { get; set; }
        public bool? StockUpdated { get; set; }
        public decimal? Vatamt { get; set; }
        public decimal? ExciseAmt { get; set; }
        public string DocNo { get; set; }
        public string PostingCode { get; set; }
        public decimal? Vatpaid { get; set; }
        public decimal? Vround { get; set; }
        public decimal? Tround { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Profit { get; set; }

        public virtual Account Account { get; set; }
        public virtual Company Branch { get; set; }
        public virtual Account Staff { get; set; }
        public virtual VtypeTran VtypeNavigation { get; set; }
        public virtual VoucherAdditional VoucherAdditional { get; set; }
        public virtual ICollection<AdditionalCharge> AdditionalCharges { get; set; }
        public virtual ICollection<DocumentRef> DocumentRefs { get; set; }
        public virtual ICollection<HrempAdvanceDetail> HrempAdvanceDetails { get; set; }
        public virtual ICollection<HrgratuityAndLeaveSalaryTran> HrgratuityAndLeaveSalaryTrans { get; set; }
        public virtual ICollection<ProdManpower> ProdManpowers { get; set; }
        public virtual ICollection<ProductionItemDetail> ProductionItemDetails { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<VoucherAllocation> VoucherAllocations { get; set; }
        public virtual ICollection<VoucherCollection> VoucherCollections { get; set; }
        public virtual ICollection<VoucherDocumentMaster> VoucherDocumentMasters { get; set; }
        public virtual ICollection<VoucherEntry> VoucherEntries { get; set; }
        public virtual ICollection<VoucherEntryDetail> VoucherEntryDetails { get; set; }
        public virtual ICollection<VoucherStatus> VoucherStatuses { get; set; }
    }
}
