using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.VAT
{
    public class OutPutVatDto
    {
        public string? Description { get; set; }
        public Decimal? VatAmountAED { get; set; }
        public Decimal? AmountAED { get; set; }
        public Decimal? CRAmount { get; set; }
        public Decimal? CRVat { get; set; }
        public Decimal? NetAmount { get; set; }
        public Decimal? NetVat { get; set; }
        public Decimal? AdjustmentAED { get; set; }
    }
}
