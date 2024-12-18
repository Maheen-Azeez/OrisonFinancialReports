using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Cmsmain
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string SendTo { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
    }
}
