using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DataArchive
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public DateTime? Pdate { get; set; }
        public decimal? Amount { get; set; }
        public string Varfield1 { get; set; }
        public int? Parent { get; set; }
    }
}
