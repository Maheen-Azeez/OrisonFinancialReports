﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hremployee
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string BankAccount { get; set; }
        public int? BankName { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string VisaType { get; set; }
        public string VisaDesignation { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string LeaveSalary { get; set; }
        public string Wbranch { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }
        public string SalaryMode { get; set; }
        public DateTime? IncremantDate { get; set; }
        public int? ProjectTranId { get; set; }
        public int? LeavePerYear { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? MinistrySalary { get; set; }
        public int? SeniorityNo { get; set; }
        public string MinistryStatus { get; set; }
        public DateTime? Eosdate { get; set; }
        public string Grade { get; set; }
        public string RemarksFinancial { get; set; }
        public string Ticket { get; set; }
        public int? LeaveOpeningBalance { get; set; }
        public DateTime? OnDate { get; set; }
        public int? LeaveTaken { get; set; }
        public decimal? BasicSalary { get; set; }
        public DateTime? FromDateTemp { get; set; }
        public DateTime? ToDateTemp { get; set; }
        public string PaymentMode { get; set; }
        public int? LoanAccount { get; set; }
        public string BankRefNo { get; set; }
        public decimal? Otrate { get; set; }
        public int? DesignationAtJoining { get; set; }
        public string GradeAtJoining { get; set; }
        public string Sponsor { get; set; }
        public string UniqueId { get; set; }
        public string AgentId { get; set; }
        public string TerminalBenefitsNominee { get; set; }
        public bool? MixedSalary { get; set; }
        public string Section { get; set; }
        public int? Approver1 { get; set; }
        public int? Approver2 { get; set; }
        public int? Approver3 { get; set; }
        public string ContractType { get; set; }
        public bool? RateIncrementByPercent { get; set; }
        public string BusinessDivision { get; set; }
        public string VehicleDescription { get; set; }
        public string AirTicketSector { get; set; }
        public decimal? NormalHour { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public string SpecialRecognition { get; set; }
        public string Memo { get; set; }
        public int? PeriodsPerWeek { get; set; }
        public int? GratuityAccount { get; set; }
        public int? LeaveSalaryAccount { get; set; }
        public int? TicketAccount { get; set; }
        public decimal? TicketAmount { get; set; }
        public string LabourCardStatus { get; set; }
        public string Campus { get; set; }
        public string Speciality { get; set; }
        public string Position { get; set; }
        public string HiredFrom { get; set; }
        public string Accomodation { get; set; }
        public string ApprovedFor { get; set; }
        public string SpouseEmployment { get; set; }
        public string SpouseNationality { get; set; }
        public int? SpouseDesignation { get; set; }
        public string SpouseQualification { get; set; }
        public string VisaCancelled { get; set; }
        public DateTime? VisaCancelledDate { get; set; }
        public string LabourCardCancelled { get; set; }
        public DateTime? LabourCardCancelledDate { get; set; }
        public string Language { get; set; }
        public string Camp { get; set; }
        public string Room { get; set; }
        public string EnglishSkill { get; set; }
        public string ComputerSkill { get; set; }
        public decimal? Rate { get; set; }
        public string Transportation { get; set; }
        public string HealthInsurance { get; set; }
        public string ChildTuition { get; set; }
        public int? NoOfChildren { get; set; }
        public string ArabicName { get; set; }
        public string JobFunction { get; set; }
        public string TeachingAssignment { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string EscalationManager { get; set; }
        public string Directreporting { get; set; }
        public string Station { get; set; }
        public DateTime? ProbationPeriod { get; set; }
        public int? NoticePeriod { get; set; }
        public string EmpStatus { get; set; }
        public string LeaveCategory { get; set; }
        public int? InsuranceAccount { get; set; }
        public decimal? InsuranceAmount { get; set; }
        public string LocalAddress { get; set; }
        public string EmpBank { get; set; }
        public string Rfid { get; set; }
        public DateTime? Incrementdate { get; set; }
        public decimal? IncrementAmount { get; set; }
        public string SubStatus { get; set; }
        public string NomineeRelation { get; set; }
        public string BusNo { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string FinRemarks { get; set; }
        public DateTime? ProbIncrDate { get; set; }
        public decimal? ProbIncrAmount { get; set; }
        public bool? Otallowance { get; set; }
        public int? SalaryHold { get; set; }
        public decimal? Hotrate { get; set; }
        public string Hrbranch { get; set; }

        public virtual Account Emp { get; set; }
        public virtual HrbranchSetting WbranchNavigation { get; set; }
    }
}
