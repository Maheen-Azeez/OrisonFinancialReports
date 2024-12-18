using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HremployeeBackup
    {
        public int EmpId { get; set; }
        public string Haddress1 { get; set; }
        public string Haddress2 { get; set; }
        public string Hcountry { get; set; }
        public string Hphone { get; set; }
        public string Pbno { get; set; }
        public string Emirates { get; set; }
        public string Area { get; set; }
        public string Email { get; set; }
        public string Rphone { get; set; }
        public string Mobile { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public string Remarks { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public int? DesignationId { get; set; }
        public int? DepartmentId { get; set; }
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
        public string Category { get; set; }
        public DateTime? IncremantDate { get; set; }
        public int? ProjectTranId { get; set; }
        public int? LeavePerYear { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? MinistrySalary { get; set; }
        public int? SeniorityNo { get; set; }
        public string MinistryStatus { get; set; }
        public string RemarksOfficial { get; set; }
        public DateTime? Eosdate { get; set; }
        public string Grade { get; set; }
        public string RemarksFinancial { get; set; }

        public virtual HrdepartmentMast Department { get; set; }
        public virtual MastDesignation Designation { get; set; }
        public virtual Account Emp { get; set; }
    }
}
