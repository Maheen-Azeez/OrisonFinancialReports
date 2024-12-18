using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrvehicleDocImage
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public int? SlNo { get; set; }
        public string Type { get; set; }
        public byte[] FileName { get; set; }
        public string Path { get; set; }
    }
}
