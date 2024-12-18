using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UniqueAccountsViewVw
    {
        public int Id { get; set; }
        public bool Editable { get; set; }
        public bool FinalAccount { get; set; }
        public int Parent { get; set; }
        public byte ParentLevel { get; set; }
        public short BranchId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public bool VoucherEntry { get; set; }
        public bool ShowChilds { get; set; }
        public byte AccountGroup { get; set; }
        public byte SubGroup { get; set; }
        public byte AccCategory { get; set; }
        public bool Isdefault { get; set; }
        public bool Deduction { get; set; }
        public byte Percentage { get; set; }
        public string Keyword { get; set; }
    }
}
