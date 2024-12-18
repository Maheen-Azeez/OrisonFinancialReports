using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrformVisibility
    {
        public int Id { get; set; }
        public string Form { get; set; }
        public bool? Visible { get; set; }
    }
}
