using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CurrencyMast
    {
        public CurrencyMast()
        {
            VoucherCurrencyDetails = new HashSet<VoucherCurrencyDetail>();
        }

        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public int? DegitsAfterDecimal { get; set; }
        public decimal? ExchangeRate { get; set; }
        public bool? Basic { get; set; }
        public DateTime? Mdate { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<VoucherCurrencyDetail> VoucherCurrencyDetails { get; set; }
    }
}
