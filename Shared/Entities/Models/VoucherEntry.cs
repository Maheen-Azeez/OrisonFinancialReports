using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherEntry
    {
        public VoucherEntry()
        {
            Cheques = new HashSet<Cheque>();
            ChequesTrans = new HashSet<ChequesTran>();
            InverseRef = new HashSet<VoucherEntry>();
            VentryAccounts = new HashSet<VentryAccount>();
            VentryCostCentres = new HashSet<VentryCostCentre>();
            VoucherEntryAdditionals = new HashSet<VoucherEntryAdditional>();
            VoucherEntryDetails = new HashSet<VoucherEntryDetail>();
        }

        public long Id { get; set; }
        public long Vid { get; set; }
        public int? SlNo { get; set; }
        public string RowType { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Reference { get; set; }
        public long? RefId { get; set; }
        public bool? VisibleonPrint { get; set; }
        public bool? Reconciled { get; set; }
        public DateTime? ReconciledDate { get; set; }
        public bool? Active { get; set; }
        public string Action { get; set; }
        public long? UserTrackId { get; set; }
        public string TranType { get; set; }
        public string PostingSubCode { get; set; }
        public string DocSubNo { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string Trnno { get; set; }
        public string SupName { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Taxable { get; set; }

        public virtual Account Account { get; set; }
        public virtual VoucherEntry Ref { get; set; }
        public virtual Voucher VidNavigation { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<ChequesTran> ChequesTrans { get; set; }
        public virtual ICollection<VoucherEntry> InverseRef { get; set; }
        public virtual ICollection<VentryAccount> VentryAccounts { get; set; }
        public virtual ICollection<VentryCostCentre> VentryCostCentres { get; set; }
        public virtual ICollection<VoucherEntryAdditional> VoucherEntryAdditionals { get; set; }
        public virtual ICollection<VoucherEntryDetail> VoucherEntryDetails { get; set; }
    }
}
