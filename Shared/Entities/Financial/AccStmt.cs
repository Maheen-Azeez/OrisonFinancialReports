using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class AccStmt
    {
        public int VID { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string VNo { get; set; }
        public string RefNo { get; set; }
        public string RowType { get; set; }
        public string Description { get; set; }
        public string MainAccountName { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int AccountId { get; set; }
        public double? Balance { get; set; }
        public double? RBalance { get; set; }
    }
}
