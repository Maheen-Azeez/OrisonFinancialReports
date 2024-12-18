using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemMasterMultiUnit
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string Unit1 { get; set; }
        public string BarCode1 { get; set; }
        public decimal? SellingPrice1 { get; set; }
        public int? Factor1 { get; set; }
        public string Unit2 { get; set; }
        public string BarCode2 { get; set; }
        public decimal? SellingPrice2 { get; set; }
        public int? Factor2 { get; set; }
        public string Unit3 { get; set; }
        public string BarCode3 { get; set; }
        public decimal? SellingPrice3 { get; set; }
        public int? Factor3 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public string VarField3 { get; set; }
        public int? Itemid { get; set; }

        public virtual ItemMaster ItemCodeNavigation { get; set; }
        public virtual UnitMaster Unit1Navigation { get; set; }
    }
}
