using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemMasterDetail
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int BranchId { get; set; }
        public string Location { get; set; }
        public string CategoryCode { get; set; }
        public decimal? NumField1 { get; set; }
        public decimal? NumField2 { get; set; }
        public decimal? NumField3 { get; set; }
        public decimal? NumField4 { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public string VarField3 { get; set; }
        public string VarField4 { get; set; }
        public string VarField5 { get; set; }
        public string VarField6 { get; set; }

        public virtual ItemMaster Item { get; set; }
    }
}
