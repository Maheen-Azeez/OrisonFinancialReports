using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Esssetting
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Value { get; set; }
        public bool? AllowDelete { get; set; }
    }
}
