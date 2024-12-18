using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VtypeTran
    {
        public VtypeTran()
        {
            EntryModeMasts = new HashSet<EntryModeMast>();
            Vouchers = new HashSet<Voucher>();
        }

        public int Id { get; set; }
        public int? BasicType { get; set; }
        public string Vtype { get; set; }
        public string Abbreviation { get; set; }
        public string Title { get; set; }
        public string PrintTitle { get; set; }
        public int DocumentType { get; set; }
        public bool AutoPosting { get; set; }
        public bool PrintAfterSave { get; set; }
        public bool ShowCheques { get; set; }
        public bool ShowAllocation { get; set; }
        public int? Numbering { get; set; }
        public bool? MustTally { get; set; }
        public bool AllowDuplicate { get; set; }
        public bool Editable { get; set; }
        public string EntryMode { get; set; }
        public int? OrderNo { get; set; }
        public string MainRowType { get; set; }
        public int? InvoiceType { get; set; }
        public int? RowType { get; set; }
        public int? CashAccount { get; set; }
        public int? BankAccount { get; set; }
        public int? CardAccount { get; set; }
        public int? PostAccount { get; set; }
        public string ArabicName { get; set; }
        public int? CctrowType { get; set; }
        public int? CcstockType { get; set; }
        public string ImportSource { get; set; }
        public bool? ToVeCc { get; set; }
        public int? Whid { get; set; }

        public virtual Account BankAccountNavigation { get; set; }
        public virtual VtypeMast BasicTypeNavigation { get; set; }
        public virtual Account CardAccountNavigation { get; set; }
        public virtual Account CashAccountNavigation { get; set; }
        public virtual DocumentTypeMast DocumentTypeNavigation { get; set; }
        public virtual EntryModeMast EntryModeNavigation { get; set; }
        public virtual NumberingTran NumberingNavigation { get; set; }
        public virtual Account PostAccountNavigation { get; set; }
        public virtual ICollection<EntryModeMast> EntryModeMasts { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
