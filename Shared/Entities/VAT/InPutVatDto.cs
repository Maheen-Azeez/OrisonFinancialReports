using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.VAT
{
    public class InPutVatDto
    {
        public string? Description { get; set; }
        public Decimal? VatAmountAED { get; set; }
        public Decimal? AmountAED { get; set; }
        public Decimal? DRAmount { get; set; }
        public Decimal? DRVat { get; set; }
        public Decimal? NetAmount { get; set; }
        public Decimal? NetVat { get; set; }
        public Decimal? AdjustmentAED { get; set; }
    }
}
