using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrapplicantQualification
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string Speciality { get; set; }
        public string University { get; set; }
        public string DateofQualification { get; set; }
        public string Country { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? ValidUntil { get; set; }

        public virtual HrapplicantDetail Applicant { get; set; }
    }
}
