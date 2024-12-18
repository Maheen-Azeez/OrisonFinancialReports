using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrgridSetting
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string GridName { get; set; }
        public string ColumnName { get; set; }
        public string OriginalCaption { get; set; }
        public string ArabicCaption { get; set; }
    }
}
