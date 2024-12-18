using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmedicalDetail
    {
        public int Id { get; set; }
        public DateTime? MedDate { get; set; }
        public string Complaint { get; set; }
        public string Treatment { get; set; }
        public string Treatmentby { get; set; }
        public string Remarks { get; set; }
        public string MedTime { get; set; }
        public int? Pid { get; set; }
    }
}
