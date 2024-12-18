using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherDocument
    {
        public int Id { get; set; }
        public int Vid { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
