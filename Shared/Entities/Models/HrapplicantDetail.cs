using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrapplicantDetail
    {
        public HrapplicantDetail()
        {
            HrapplicantQualifications = new HashSet<HrapplicantQualification>();
            HrdependentDetails = new HashSet<HrdependentDetail>();
        }

        public int Id { get; set; }
        public string ApplicantFileNumber { get; set; }
        public string RecruitmentAgency { get; set; }
        public string RecruiterRecordNumber { get; set; }
        public string InterviewCityLocation { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string InterviewPanelMembers { get; set; }
        public int? InterviewRatings { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string FirstNameArabic { get; set; }
        public string SecondName { get; set; }
        public string SecondNameArabic { get; set; }
        public string ThirdName { get; set; }
        public string ThirdNameArabic { get; set; }
        public string FamilyName { get; set; }
        public string FamilyNameArabic { get; set; }
        public string FullName { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string CityOfBirth { get; set; }
        public string CityOfBirthArabic { get; set; }
        public string CountryOfBirth { get; set; }
        public string CountryOfBirthArabic { get; set; }
        public string MaritalStatus { get; set; }
        public int? NoOfChildrens { get; set; }
        public string Religion { get; set; }
        public string ReligionArabic { get; set; }
        public string Sect { get; set; }
        public string SectArabic { get; set; }
        public string CurrentNationality { get; set; }
        public string CurrentNationalityArabic { get; set; }
        public int? LengthOfCitizenship { get; set; }
        public string PreviousNationality { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportIissueDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string PassportType { get; set; }
        public string PassportIssuePlace { get; set; }
        public string PassportIssueCountry { get; set; }
        public string PassportIssueAuthority { get; set; }
        public string ResidentOfUae { get; set; }
        public string EmiratesIdnumber { get; set; }
        public string CurrentSponsor { get; set; }
        public string UaevisaNumber { get; set; }
        public string Uidnumber { get; set; }
        public string CurrentResidenceCity { get; set; }
        public string CurrentResidenceCountry { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string HomeMobile { get; set; }
        public string Email { get; set; }
        public string CurrentPostion { get; set; }
        public string PrevJobInArabic { get; set; }
        public string TeachingLicenceSuspende { get; set; }
        public string YearOfP12exp { get; set; }
        public string Specialization { get; set; }
        public string HighestQualification { get; set; }
        public string HighestQualificationArabic { get; set; }
        public string YearsOfExpInSchool { get; set; }
        public string TeachingLevel { get; set; }
        public string RecommendedRegion { get; set; }
        public string RecommendedOrganizationId { get; set; }
        public string RecommendedOrganizationName { get; set; }
        public string RecommendedLocation { get; set; }
        public string RecommendedSchoolGender { get; set; }
        public string HeadofFacultyRecommendation { get; set; }
        public string Placementcomments { get; set; }
        public string RelativeInSchool { get; set; }
        public string RelativeName { get; set; }
        public string SpouseEmployedBySchool { get; set; }
        public string SpouseErpno { get; set; }
        public string SpouseName { get; set; }
        public string DepartureCity { get; set; }
        public string RepatriationCountry { get; set; }
        public string RepatriationCity { get; set; }
        public string NearestAirportCode { get; set; }
        public string NearestAirport { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactEmail { get; set; }
        public string EmergencyContactNo { get; set; }
        public string EmployedBySchool { get; set; }
        public string InterviewedBySchool { get; set; }
        public string CriminalRecord { get; set; }
        public string DrivingLicense { get; set; }
        public string DrivingLicenseCountry { get; set; }
        public string OfferSent { get; set; }
        public string OfferAccepted { get; set; }
        public string PscapprovalStatus { get; set; }
        public string Grade { get; set; }
        public decimal? BasicSalary { get; set; }
        public string BatchNumber { get; set; }
        public string OrientationGroup { get; set; }
        public string VacancyName { get; set; }
        public string SecurityDocsSubmitted { get; set; }
        public string SecurityPassed { get; set; }
        public string TicketsRequired { get; set; }
        public string HospitalityRequired { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public bool? Exported { get; set; }

        public virtual ICollection<HrapplicantQualification> HrapplicantQualifications { get; set; }
        public virtual ICollection<HrdependentDetail> HrdependentDetails { get; set; }
    }
}
