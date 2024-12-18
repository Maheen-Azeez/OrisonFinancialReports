using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcsdocumentsTrack
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public string FileName { get; set; }
        public DateTime? Date { get; set; }
        public string Action { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
