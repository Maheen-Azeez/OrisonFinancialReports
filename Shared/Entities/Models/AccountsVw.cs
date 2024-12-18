using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AccountsVw
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int ParentLevel { get; set; }
        public bool VoucherEntry { get; set; }
        public bool FinalAccount { get; set; }
        public string AccountGroup { get; set; }
        public string SubGroup { get; set; }
        public string AccCategory { get; set; }
        public bool? ShowChild { get; set; }
        public bool? Isdefault { get; set; }
        public bool? AllowEntry { get; set; }
        public bool InActive { get; set; }
        public bool? Editable { get; set; }
        public string Parent { get; set; }
        public int? SubGroupOrderNo { get; set; }
        public int? ParentId { get; set; }
        public int? SubGroupDivision { get; set; }
        public int AccountGroupId { get; set; }
        public int? SubGroupId { get; set; }
        public int? AccCategoryId { get; set; }
        public string GroupType { get; set; }
        public int? BranchId { get; set; }
        public int? AorderNo { get; set; }
        public int? Ccid { get; set; }
        public string Cccode { get; set; }
        public string Ccname { get; set; }
        public bool? InVisible { get; set; }
        public decimal? SortField { get; set; }
        public bool? ShowRow { get; set; }
    }
}
