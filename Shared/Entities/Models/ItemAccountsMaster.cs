using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemAccountsMaster
    {
        public int Id { get; set; }
        public int? Itemid { get; set; }
        public int? Accountid { get; set; }
        public string Acccategory { get; set; }
        public string Remarks { get; set; }
        public int? Field1 { get; set; }
        public int? Field2 { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
    }
}
