using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherEntryVw
    {
        public long Id { get; set; }
        public long Vid { get; set; }
        public int? SlNo { get; set; }
        public string RowType { get; set; }
        public bool? VisibleonPrint { get; set; }
        public bool? Reconciled { get; set; }
        public DateTime? ReconciledDate { get; set; }
        public bool? Active { get; set; }
        public string Action { get; set; }
        public long? UserTrackId { get; set; }
        public long? RefId { get; set; }
        public int AccountId { get; set; }
        public string TranType { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountHead { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? ChequeId { get; set; }
        public int? CardType { get; set; }
        public decimal? Commission { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? Date { get; set; }
        public int? ClrDays { get; set; }
        public int? BankId { get; set; }
        public string BankName { get; set; }
        public string Status { get; set; }
        public int? PartyId { get; set; }
        public string Card { get; set; }
        public string DepositTo { get; set; }
        public int Vtype { get; set; }
        public int BranchId { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string Trnno { get; set; }
        public string SupName { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Taxable { get; set; }
    }
}
