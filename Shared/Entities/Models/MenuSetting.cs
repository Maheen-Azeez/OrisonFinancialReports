using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class MenuSetting
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string Section { get; set; }
        public bool Visible { get; set; }
        public string OriginalTitle { get; set; }
        public string NewTitle { get; set; }
    }
}
