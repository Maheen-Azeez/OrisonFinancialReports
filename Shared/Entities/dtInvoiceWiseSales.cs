using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities
{
    public class dtInvoiceWiseSales
    {
        public int VID { get; set; }
        public DateTime? VDate { get; set; }
        public string? Vno { get; set; }
        public int ItemID { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public string? TAXCode { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Profit { get; set; }
        public string? Description { get; set; }
        public decimal? AvgCost { get; set; }
        public decimal? Amount { get; set; }
    }
}
