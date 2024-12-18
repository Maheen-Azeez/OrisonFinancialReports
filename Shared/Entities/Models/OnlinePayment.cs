using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class OnlinePayment
    {
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string OrderNo { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string CardType { get; set; }
        public string ResponseMessage { get; set; }
        public int? ReferenceId { get; set; }
    }
}
