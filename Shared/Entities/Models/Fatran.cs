using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Fatran
    {
        public long Id { get; set; }
        public string AssetNo { get; set; }
        public string Slno { get; set; }
        public DateTime? Date { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public string Major { get; set; }
        public string Middle { get; set; }
        public string Minor { get; set; }
        public string Sub { get; set; }
        public string Type { get; set; }
        public string Remarks { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }
        public int? StaffId { get; set; }

        public virtual Famaster AssetNoNavigation { get; set; }
    }
}
