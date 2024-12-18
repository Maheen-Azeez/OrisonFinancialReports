using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrcandidateApplication
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string EducationalPermitNo { get; set; }
        public string NominatedJob { get; set; }
        public string Subject { get; set; }
        public string AcademicLevel { get; set; }
        public int? NoOfCurrentEmployees { get; set; }
        public string CandidateName { get; set; }
        public string Nationality { get; set; }
        public DateTime? Dob { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string PassportIssuedBy { get; set; }
        public string VisaNo { get; set; }
        public DateTime? VisaIssueDate { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public string Sponsor { get; set; }
        public string AcademicQualification1 { get; set; }
        public string Specialization1 { get; set; }
        public DateTime? QualificationDate1 { get; set; }
        public string QualificationIssuedBy1 { get; set; }
        public string AcademicQualification2 { get; set; }
        public string Specialization2 { get; set; }
        public DateTime? QualificationDate2 { get; set; }
        public string QualificationIssuedBy2 { get; set; }
        public string AcademicQualification3 { get; set; }
        public string Specialization3 { get; set; }
        public DateTime? QualificationDate3 { get; set; }
        public string QualificationIssuedBy3 { get; set; }
        public string Experience { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime? Date { get; set; }
        public string SubmittedBy { get; set; }
    }
}
