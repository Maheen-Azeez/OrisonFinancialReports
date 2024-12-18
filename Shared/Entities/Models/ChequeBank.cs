using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ChequeBank
    {
        public int Id { get; set; }
        public int? BankId { get; set; }
        public string ChequeCode { get; set; }
        public bool? Active { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Account Bank { get; set; }
        public virtual ChequeSetting ChequeCodeNavigation { get; set; }
    }
}
