using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class MonthlyProfit
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal? DirectRevenue { get; set; }
        public decimal? IndirectRevenue { get; set; }
        public decimal? DirectExpense { get; set; }
        public decimal? IndirectExpense { get; set; }
        public decimal? GP { get; set; }
        public decimal? RGP { get; set; }
        public decimal? NP { get; set; }
        public decimal? RNP { get; set; }
    }
}
