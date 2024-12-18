using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempExperienceImage
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? PageNo { get; set; }
        public byte[] Picture { get; set; }
        public int? ExpId { get; set; }
    }
}
