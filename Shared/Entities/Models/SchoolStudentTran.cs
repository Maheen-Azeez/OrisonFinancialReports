using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SchoolStudentTran
    {
        public int Id { get; set; }
        public string AcademicYear { get; set; }
        public int AccountId { get; set; }
        public string RollNo { get; set; }
        public string Status { get; set; }
        public string PrevStatus { get; set; }
        public string Prevclass { get; set; }
        public string Class { get; set; }
        public string Division { get; set; }
        public DateTime? StartsFrom { get; set; }
        public string Ssection { get; set; }
        public string FinalResult { get; set; }
        public string ReTestResult { get; set; }
        public int? ClNo { get; set; }
        public string OptionalDivision { get; set; }
        public DateTime? ActualJoiningDate { get; set; }
        public string Shift { get; set; }
        public int? ClassNo { get; set; }
        public bool? Reregistered { get; set; }
        public bool? Result { get; set; }
        public bool? IdPrinted { get; set; }
        public string FeeSchedule { get; set; }
        public string TransSchedule { get; set; }
        public string AdmissionSchedule { get; set; }
        public string DiscountSchedule { get; set; }
        public string TranDiscountSchedule { get; set; }
        public bool? FeeDiscount { get; set; }
        public bool? TranDiscount { get; set; }

        public virtual Account Account { get; set; }
    }
}
