using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AgingDetailsTerm
    {
        public int? StartDay { get; set; }
        public int? EndDay { get; set; }
        public int? Priority { get; set; }
        public string Title { get; set; }
    }
}
