using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DynamicMenu
    {
        public int Id { get; set; }
        public string ParentMenu { get; set; }
        public string MenuName { get; set; }
        public string MenuText { get; set; }
        public string EventName { get; set; }
        public string ShortCut { get; set; }
    }
}
