using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class MenuMaster
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Reportname { get; set; }
        public string Url { get; set; }
        public string Remarks { get; set; }
        public string CategoryImage { get; set; }
        public string Type { get; set; }
    }
}
