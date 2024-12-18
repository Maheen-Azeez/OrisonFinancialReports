using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class ConsolidatedBranchWise
    {
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal Cedar { get; set; }
        public decimal Corporate { get; set; }
        public decimal Dubai { get; set; }
        public decimal KSA { get; set; }
        public decimal Sharjah { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Total { get; set; }
        public int? VoucherEntry { get; set; }
        
    }
}
