using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebOrganization
    {
        public int Id { get; set; }
        public int? CompanyType { get; set; }
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
        public DateTime? EntryFrom { get; set; }
    }
}
