using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SchoolAcademicYear
    {
        public int Id { get; set; }
        public string AcademicYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public int? Semester { get; set; }
        public int? Year { get; set; }
        public string AgeCalculationDate { get; set; }
        public string Admission { get; set; }
    }
}
