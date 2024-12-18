using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrimage
    {
        public string EmpCode { get; set; }
        public byte[] Image { get; set; }
    }
}
