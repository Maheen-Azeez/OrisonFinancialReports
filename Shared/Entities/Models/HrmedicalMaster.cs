using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmedicalMaster
    {
        public int Id { get; set; }
        public int Empid { get; set; }
        public string BloodGroup { get; set; }
        public string Allergies { get; set; }
        public string Remarks { get; set; }
        public string History1 { get; set; }
        public string History2 { get; set; }
        public string History3 { get; set; }
        public DateTime? VaccinationDate { get; set; }
    }
}
