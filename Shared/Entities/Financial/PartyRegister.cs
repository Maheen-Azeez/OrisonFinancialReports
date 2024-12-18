using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class PartyRegister
    {

        public int ID { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Renewaldate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SalesRep   { get; set; }
        public string Status { get; set; }
        public string CRemarks { get; set; }
        public decimal? Balance { get; set; }

    }
}
