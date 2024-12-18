using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.DashBoard
{
    public class Finance
    {
        public string SchoolCode { get; set; }
        public double Revenue { get; set; }
        public double BankBalance { get; set; }
        public double CashInflow { get; set; }
        public double CashOutFlow { get; set; }
        public Finance()
        {

        }
    }
}
