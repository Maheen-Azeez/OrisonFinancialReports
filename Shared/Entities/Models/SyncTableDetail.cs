using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SyncTableDetail
    {
        public int Id { get; set; }
        public string Table { get; set; }
        public DateTime? Mdate { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public int? Numfield1 { get; set; }
        public int? Numfield2 { get; set; }
    }
}
