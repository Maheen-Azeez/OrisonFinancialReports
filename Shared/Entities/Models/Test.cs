using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Test
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int? Parent { get; set; }
        public int ParentLevel { get; set; }
        public bool? VoucherEntry { get; set; }
        public bool FinalAccount { get; set; }
        public int AccountGroup { get; set; }
        public int? SubGroup { get; set; }
        public int? AccCategory { get; set; }
        public bool? ShowChild { get; set; }
        public bool? Isdefault { get; set; }
        public bool? AllowEntry { get; set; }
        public bool InActive { get; set; }
        public bool? Editable { get; set; }
        public long? UserTrackId { get; set; }
        public int? Currency { get; set; }
        public int? BranchId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUser { get; set; }
        public int? ModifiedUser { get; set; }
        public int EmpId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
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
    }
}
