using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Gcheque
    {
        public int Id { get; set; }
        public string Gno { get; set; }
        public DateTime? Curdate { get; set; }
        public int? Accountid { get; set; }
        public DateTime? Chqdate { get; set; }
        public string Chqno { get; set; }
        public string Bank { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string AccCategory { get; set; }
        public decimal? ChqAmt { get; set; }

        public virtual Account Account { get; set; }
    }
}
