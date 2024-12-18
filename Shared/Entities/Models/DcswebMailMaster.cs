using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebMailMaster
    {
        public int Id { get; set; }
        public int? Gid { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
        public string ToInt { get; set; }
        public string ToExt { get; set; }
        public string Ccint { get; set; }
        public string Ccext { get; set; }
        public string Approver1 { get; set; }
        public string Approver2 { get; set; }
        public string Approver3 { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string CcintUserName { get; set; }
        public string GroupTo { get; set; }
        public string GroupToName { get; set; }
    }
}
