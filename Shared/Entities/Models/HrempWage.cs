using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempWage
    {
        public HrempWage()
        {
            HrempWagesDeductions = new HashSet<HrempWagesDeduction>();
            HrempWagesIncomes = new HashSet<HrempWagesIncome>();
        }

        public int Id { get; set; }
        public int EmpId { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public DateTime? Date { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? TotalRate { get; set; }
        public decimal? TotalWages { get; set; }
        public decimal? Totaldeduction { get; set; }
        public string Project { get; set; }
        public decimal? NetSalary { get; set; }
        public decimal? DaysWorked { get; set; }
        public int? TotalDays { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? TotalAllowance { get; set; }
        public string RollNo { get; set; }
        public decimal? Advance { get; set; }
        public bool? PrintStatus { get; set; }
        public int? PostId { get; set; }
        public int? PostNetId { get; set; }
        public string Description { get; set; }
        public DateTime? SalaryDate { get; set; }
        public string PaymentMode { get; set; }
        public decimal? LeaveDays { get; set; }
        public decimal? CashAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? ActualSalary { get; set; }
        public bool? EmailStatus { get; set; }
        public string Category { get; set; }
        public bool? SalaryHold { get; set; }
        public string Wbranch { get; set; }
        public string BankAccount { get; set; }
        public string Department { get; set; }
        public string UniqueId { get; set; }
        public string BankRefNo { get; set; }
        public int? BankName { get; set; }
        public string AgentId { get; set; }
        public string EmpBank { get; set; }
        public bool? PaidStatus { get; set; }

        public virtual Account Emp { get; set; }
        public virtual ICollection<HrempWagesDeduction> HrempWagesDeductions { get; set; }
        public virtual ICollection<HrempWagesIncome> HrempWagesIncomes { get; set; }
    }
}
