using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class PDC
    {
        public int VID { get; set; }
        public int ID { get; set; }
        public int VEID { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? Vdate { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string Vno { get; set; }
        public DateTime? PostedDate { get; set; }
        public string PostedVno { get; set; }
        public string Status { get; set; }
        public string Substatus { get; set; }
        public int? AccountID { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public int? PartyID { get; set; }
        public string PartyCode { get; set; }
        public string Party { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
