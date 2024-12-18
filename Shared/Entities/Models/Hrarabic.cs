using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrarabic
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Place { get; set; }
        public string Qualification { get; set; }
        public string Occupation { get; set; }
        public string Sponsor { get; set; }
        public string ResidenceStatus { get; set; }
        public string Subject { get; set; }
        public string Grade { get; set; }
        public string Specialization { get; set; }
        public string Notes { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Issuance { get; set; }
        public DateTime? School { get; set; }
        public bool? Notification { get; set; }
        public decimal? Salary { get; set; }
        public decimal? NoOfShares { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public string Stages { get; set; }
        public string Section { get; set; }
        public string SponsorNumber { get; set; }
        public string Major { get; set; }
        public string State { get; set; }
        public string PlaceOfbirth { get; set; }
        public string LastEmployer { get; set; }
        public string NoOfclasses { get; set; }
        public string DirectSupervisor { get; set; }
        public string DirectExtention { get; set; }
        public string Designation { get; set; }
        public string Emirates { get; set; }
        public string Maritalstatus { get; set; }
        public string MinistryApproval { get; set; }
        public string Approvalposition { get; set; }
        public string ApprovalGrades { get; set; }
        public string MothersName { get; set; }
        public string Docterine { get; set; }
        public string EducationLevel { get; set; }
        public string OutsideExperience { get; set; }
        public string InsideExperience { get; set; }
        public string EquivalenceCertificate { get; set; }
        public string IssuePlacePassport { get; set; }
        public string VisaPostion { get; set; }
        public string IssuePlaceVisa { get; set; }
    }
}
