using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdependentDetail
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string DependentFirstName { get; set; }
        public string DependentSecondName { get; set; }
        public string DependentThirdName { get; set; }
        public string DependentFamilyName { get; set; }
        public string DependentFullName { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string PlaceofBirth { get; set; }
        public string CountryofCitizenship { get; set; }
        public string LiveInAbudhabi { get; set; }
        public string Adopted { get; set; }
        public string DepExplanation { get; set; }
        public string CityofBirth { get; set; }
        public string CountryofBirth { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string PassportIssuePlace { get; set; }
        public string PassportType { get; set; }
        public string PassportAuthority { get; set; }
        public string TicketEligibleRequired { get; set; }
        public string TempAccommodation { get; set; }

        public virtual HrapplicantDetail Applicant { get; set; }
    }
}
