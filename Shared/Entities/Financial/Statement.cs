namespace OrisonMIS.Shared.Entities.Financial
{
    public class Statement
    {
        public decimal ID { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string VoucherEntry { get; set; }
        public int? ParentLevel { get; set; }
        public decimal SortField { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Amount { get; set; }
        public int? ParentID { get; set; }
        public bool ShowRow { get; set; }
        public bool ShowChild { get; set; }

    }
}
