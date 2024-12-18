using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrform
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string FormName { get; set; }
        public string Description { get; set; }
    }
}
