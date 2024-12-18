using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrbranchSetting
    {
        public HrbranchSetting()
        {
            HrcompDocuments = new HashSet<HrcompDocument>();
            Hremployees = new HashSet<Hremployee>();
            Hrwpsmasters = new HashSet<Hrwpsmaster>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? Pbno { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Branch { get; set; }
        public string UniqueId { get; set; }
        public string BankCode { get; set; }
        public string Reference { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAddress1 { get; set; }
        public string BankAddress2 { get; set; }
        public string SenderEmail { get; set; }
        public int? SupplierId { get; set; }

        public virtual Account Supplier { get; set; }
        public virtual ICollection<HrcompDocument> HrcompDocuments { get; set; }
        public virtual ICollection<Hremployee> Hremployees { get; set; }
        public virtual ICollection<Hrwpsmaster> Hrwpsmasters { get; set; }
    }
}
