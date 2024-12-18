using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Company
    {
        public Company()
        {
            Accounts = new HashSet<Account>();
            AvgCostNews = new HashSet<AvgCostNew>();
            AvgCosts = new HashSet<AvgCost>();
            CompanyBranchHrs = new HashSet<CompanyBranchHr>();
            HrattendanceStations = new HashSet<HrattendanceStation>();
            UsersBranches = new HashSet<UsersBranch>();
            Vouchers = new HashSet<Voucher>();
            WarehouseBranches = new HashSet<WarehouseBranch>();
        }

        public int Id { get; set; }
        public int CompanyType { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string BranchName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public DateTime EntryFrom { get; set; }
        public string LetterHead { get; set; }
        public bool? AllowDelete { get; set; }
        public string Currency { get; set; }
        public int? SalesAccount { get; set; }
        public int? InvAccount { get; set; }
        public int? CostAccount { get; set; }
        public int? CashAccount { get; set; }
        public int? CardAccount { get; set; }
        public int? BankAccount { get; set; }
        public int? DiscountAccount { get; set; }
        public string ReportPath { get; set; }
        public string ReportPathVpn { get; set; }
        public string Trnno { get; set; }
        public string Vatplace { get; set; }

        public virtual CompanyTypeMast CompanyTypeNavigation { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<AvgCostNew> AvgCostNews { get; set; }
        public virtual ICollection<AvgCost> AvgCosts { get; set; }
        public virtual ICollection<CompanyBranchHr> CompanyBranchHrs { get; set; }
        public virtual ICollection<HrattendanceStation> HrattendanceStations { get; set; }
        public virtual ICollection<UsersBranch> UsersBranches { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
        public virtual ICollection<WarehouseBranch> WarehouseBranches { get; set; }
    }
}
