using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrreminder
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
    }
}
