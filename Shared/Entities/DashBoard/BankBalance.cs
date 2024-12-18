using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.DashBoard
{
    public class BankBalance
    {
        public string SchoolCode { get; set; }
        public string BankName { get; set; }
        public double Amount { get; set; }
        public BankBalance()
        {

        }
    }
}
