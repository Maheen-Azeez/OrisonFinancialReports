using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrsmsmaster
    {
        public int Id { get; set; }
        public int Refno { get; set; }
        public string Message { get; set; }
        public string Approvedby { get; set; }
        public string Senderid { get; set; }
        public DateTime? Createddate { get; set; }
        public string Status { get; set; }
        public DateTime? Senddate { get; set; }
        public string Language { get; set; }
        public string Topic { get; set; }
    }
}
