using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class MobileSyncLog
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public DateTime? Lmtime { get; set; }
        public DateTime? SyncTime { get; set; }
        public int? SyncRowCount { get; set; }
    }
}
