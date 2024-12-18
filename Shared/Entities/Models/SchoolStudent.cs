using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SchoolStudent
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Ssection { get; set; }
        public string StudentStatus { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NameInArabic { get; set; }
        public string Sex { get; set; }
        public string Religion { get; set; }
        public string MotherTongue { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfbirth { get; set; }
        public string Slanguage { get; set; }
        public string OpLanguage1 { get; set; }
        public string OpLanguage2 { get; set; }
        public string OpDivision { get; set; }
        public string PrevSchool { get; set; }
        public string PrevPlace { get; set; }
        public string PrevStatus { get; set; }
        public string PrevClass { get; set; }
        public string MinistryStatus { get; set; }
        public string RegisterNo { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string BusMode { get; set; }
        public string BusNo { get; set; }
        public string GoingBusNo { get; set; }
        public string BusPoint { get; set; }
        public string BusArea { get; set; }
        public string Emirates { get; set; }
        public string BusTimeIn { get; set; }
        public string BusTimeOut { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string PassportIssuePlace { get; set; }
        public string PassportStatus { get; set; }
        public string VisaNo { get; set; }
        public DateTime? VisaIssueDate { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public string VisaIssuePlace { get; set; }
        public bool? DocTc { get; set; }
        public bool? DocBirthCertificate { get; set; }
        public bool? DocPassport { get; set; }
        public DateTime? LeavingDate { get; set; }
        public string LeavingReason { get; set; }
        public string JoiningClass { get; set; }
        public string JoiningDivision { get; set; }
        public string TcType { get; set; }
        public string TcDetails { get; set; }
        public DateTime? TcDate { get; set; }
        public string Tcto { get; set; }
        public string JoiningAcademicYear { get; set; }
        public string ArabNonArab { get; set; }
        public string SportsHouse { get; set; }
        public string PrevTcType { get; set; }
        public string Programme { get; set; }
        public string Plan { get; set; }
        public string FeeSchedule { get; set; }
        public string TransSchedule { get; set; }
        public string ActivitySchedule { get; set; }
        public string DiscountSchedule { get; set; }
        public bool Termwise { get; set; }
        public string Remarks { get; set; }
        public string Processedby { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string VisaStatus { get; set; }
        public string Email { get; set; }
        public bool? DocPhoto { get; set; }
        public bool? DocVaccinationCard { get; set; }
        public string AdmissionSchedule { get; set; }
        public bool? Blocked { get; set; }
        public string BusName { get; set; }
        public string PrevDivision { get; set; }
        public bool? FeeDiscount { get; set; }
        public bool? TranDiscount { get; set; }
        public bool? IsSibling { get; set; }
        public bool? DocFatherPassport { get; set; }
        public string FirstName { get; set; }
        public string FirstNameInArabic { get; set; }
        public string MiddleNameInArabic { get; set; }
        public string LastNameInArabic { get; set; }
        public string PdcRemarks { get; set; }
        public string MotherNameActual { get; set; }
        public string MotherAddressActual { get; set; }
        public string MotherPoBoxActual { get; set; }
        public string MotherProfessionActual { get; set; }
        public string MotherCityActual { get; set; }
        public string MotherCountryActual { get; set; }
        public string MotherOfficeTelActual { get; set; }
        public string MotherHomeTelActual { get; set; }
        public string MotherMobile1Actual { get; set; }
        public string MotherMobile2Actual { get; set; }
        public string MotherEmail1Actual { get; set; }
        public string MotherEmail2Actual { get; set; }
        public bool? MotherSpeakEnglishActual { get; set; }
        public DateTime? TestingDate { get; set; }
        public string MotherWorkingPlaceActual { get; set; }
        public string MotherCompanyActual { get; set; }
        public string RelationContactsActual { get; set; }
        public string DropOffPoint { get; set; }
        public int? BusStopNo { get; set; }
        public int? BusStopNoTo { get; set; }
        public bool? EntranceExam { get; set; }
        public string TranDiscountSchedule { get; set; }
        public string GoingTrip { get; set; }
        public string ComingTrip { get; set; }

        public virtual Account Account { get; set; }
        public virtual HrtransportationMast BusNoNavigation { get; set; }
    }
}
