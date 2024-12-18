using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class FormLabelSetting
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string LabelName { get; set; }
        public string OriginalCaption { get; set; }
        public string NewCaption { get; set; }
        public bool? Visible { get; set; }
    }
}
