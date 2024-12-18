using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrformSetting
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string LabelName { get; set; }
        public string Caption { get; set; }
        public string ArabicCaption { get; set; }
    }
}
