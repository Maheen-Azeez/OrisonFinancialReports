using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class BankDetail
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string BankName { get; set; }
        public string BankAddress1 { get; set; }
        public string BankAddress2 { get; set; }
        public string BankPhoneNo { get; set; }
        public string BankFaxNo { get; set; }
        public string BankEmailId { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public string Ibanno { get; set; }
        public string SwiftCode { get; set; }
        public string RegionalManagerName { get; set; }
        public string RegionalManagerMobNo { get; set; }
        public string NameOnCheque { get; set; }
        public string BvarField1 { get; set; }
        public string BvarField2 { get; set; }
        public string Bvarfield3 { get; set; }
        public decimal? BnumField1 { get; set; }
        public decimal? BnumField2 { get; set; }
        public decimal? BnumField3 { get; set; }
        public DateTime? Bdate1 { get; set; }
        public DateTime? Bdate2 { get; set; }

        public virtual Account Account { get; set; }
    }
}
