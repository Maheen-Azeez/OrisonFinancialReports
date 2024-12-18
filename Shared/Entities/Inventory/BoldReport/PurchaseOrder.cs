using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory.BoldReport
{
    public class PurchaseOrder
    {
        public List<Company> CompanyDetails { get; set; }
        public List<Transaction> TransactionDetails { get; set; }
        public List<PurchaseDetails> OrderDetails { get; set; }
    }
    public class Transaction
    {
        public string SlNo { get; set; }
        public string Description { get; set; }
        public string VarField3 { get; set; }
        public string Unit { get; set; }
        public string Qty { get; set; }
        public string Rate { get; set; }
        public string VAT { get; set; }
        public string ISBN { get; set; }
    }
    public class PurchaseDetails
    {
        public string VNoInt { get; set; }
        public string AccountName { get; set; }
        public string Phone1 { get; set; }
        public string OfficialEmail { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CommonNarration { get; set; }
        public string TRNNo { get; set; }
        public string IssueDate { get; set; }
        public string DueDate { get; set; }
        public string TodayDate { get; set; }
        public string TodayTime { get; set; }
        public string FooterText { get; set; }
        public string PaymentTerms { get; set; }
        public string ContactPerson { get; set; }
        public string QuotatioNo { get; set; }
        public DateTime QuotationDate { get; set; }
        public string MagorGroup { get; set; }
    }
    public class Company
    {
        public string ID { get; set; }
        public string CompanyType { get; set; }
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
        public string Currency { get; set; }
        public string TRNNo { get; set; }
        public string ERNNo { get; set; }
        public string VATPlace { get; set; }
    }
}
