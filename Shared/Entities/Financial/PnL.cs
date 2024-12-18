using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class PnL
    {
        public int? ID { get; set; }
        public int? VoucherEntry { get; set; }
        public int? ParentID { get; set; }
        public int? ParentLevel { get; set; }
        public int? AccountGroupID { get; set; }
        public int? SubGroupOrderNo { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal? SortField { get; set; }
        public int? ShowChild { get; set; }
        public int? AOrderNo { get; set; }
        public int? ShowRow { get; set; }
        public int? PandLGroup { get; set; }
        public string GroupType { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Amount { get; set; }
       
    }
}
