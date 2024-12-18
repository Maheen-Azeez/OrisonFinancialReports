using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.VAT
{
    public class CurrentVatDto
    {
        public string? Description { get; set; }
        public Decimal? VatAmountAED { get; set; }
    }
}
