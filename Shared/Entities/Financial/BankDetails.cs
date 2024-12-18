using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class BankDetails
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string BankName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? Amount { get; set; }
    }
}
