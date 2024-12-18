using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebDocument1
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public decimal? Version { get; set; }
        public string Size { get; set; }

        public virtual DcswebDocMaster Doc { get; set; }
    }
}
