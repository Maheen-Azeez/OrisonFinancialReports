using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities
{
    public class dtSalesAnalysis
    {
        public DateTime? VDate { get; set; }
        public decimal? SAmt { get; set; }
        public decimal? CashAmt { get; set; }
        public decimal? SRAmt { get; set; }
        public decimal? SCost { get; set; }
        public decimal? SRCost { get; set; }
        public decimal? NetSales { get; set; }
        public decimal? CostOfSales { get; set; }
        public decimal? Profit { get; set; }
    }
}
