using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.SharedSAPI.Models
{
    public partial class GroupsVw
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int? Parent { get; set; }
        public byte ParentLevel { get; set; }
        public bool? VoucherEntry { get; set; }
        public bool FinalAccount { get; set; }
        public bool? ShowChild { get; set; }
        public bool? Isdefault { get; set; }
        public bool? AllowEntry { get; set; }
        public bool? InActive { get; set; }
        public bool? Editable { get; set; }
        public string AccountGroup { get; set; }
        public string SubGroup { get; set; }
        public short? SubGroupOrderNo { get; set; }
        public byte? SubGroupDivision { get; set; }
        public byte AccountGroupId { get; set; }
        public byte? SubGroupId { get; set; }
    }
}
