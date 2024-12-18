using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class CashFlow
    {
        public string SchoolCode { get; set; }
        public int? ID { get; set; }
        public int? VoucherEntry { get; set; }
        public int? ParentID { get; set; }
        public int? ParentLevel { get; set; }
        public int? ShowRow { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal? Inflow { get; set; }
        public decimal? Outflow { get; set; }
      

    }
}
