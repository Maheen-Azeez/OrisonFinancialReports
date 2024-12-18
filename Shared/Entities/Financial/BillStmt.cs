using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class BillStmt
    {
        public int VID { get; set; }
        public int VEID { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string VNo { get; set; }
        public string RefNo { get; set; }
        public string Description { get; set; }
        public int Days { get; set; }
        public int Months { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public double? RBalance { get; set; }
        public int AccountID { get; set; }
    }
}
