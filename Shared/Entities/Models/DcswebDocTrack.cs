using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebDocTrack
    {
        public long Id { get; set; }
        public long? DocId { get; set; }
        public long? UserId { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
        public string Reference { get; set; }
        public string MachineName { get; set; }
        public string ModuleName { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }

        public virtual DcswebDocument Doc { get; set; }
    }
}
