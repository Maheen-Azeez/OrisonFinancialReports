using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class BudgetReg
    {
        public int? AccountID { get; set; }
        public int? ParentID { get; set; }
        public int? VoucherEntry { get; set; }
        public int? ParentLevel { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal? SortField { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Actual { get; set; }
        public decimal? Variance { get; set; }
        public decimal? AmountUptodate { get; set; }
        public decimal? ActualAmountUptodate { get; set; }
        public decimal? BudgetPerc { get; set; }
       
    }
}
