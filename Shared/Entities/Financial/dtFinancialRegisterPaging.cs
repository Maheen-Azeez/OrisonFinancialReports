using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class dtFinancialRegisterPaging
    {
        public List<dtFinancialRegister> Data { get; set; }
        public int Count { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
