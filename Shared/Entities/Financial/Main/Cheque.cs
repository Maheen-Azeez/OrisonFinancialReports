using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial.Main
{
    public class Cheque
    {
        [Key]
        public int ID { get; set; }
        public long VEID { get; set; }
        public int CardType { get; set; }
        public decimal? Commission { get; set; }
        public string ChequeNo { get; set; }
        public DateTime?  ChequeDate { get; set; }
        public int ClrDays { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string Status { get; set; }
        public int PartyID { get; set; }
        public string PartyName { get; set; }
        public string TranType { get; set; }


    }
}
