using System.ComponentModel.DataAnnotations;

namespace OrisonMIS.Shared.Entities.Inventory.Reports
{
    public class DailyReport
    {
        public string UserName { get; set; }
        public string VType { get; set; }
        public string VNo { get; set; }
        public DateTime MDate { get; set; }
        public DateTime VDate { get; set; }
        public string Customer { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Cheque { get; set; }
        public decimal? Card { get; set; }
        public decimal? CashSales { get; set; }
        public decimal? CreditSales { get; set; }
        [Key]
        public long ID { get; set; }


    }
}
