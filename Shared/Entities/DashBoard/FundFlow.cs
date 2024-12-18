using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.DashBoard
{
    public class FundFlow
    {
        public string SchoolCode { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public double InFlow { get; set; }
        public double OutFlow { get; set; }
        public FundFlow()
        {

        }
    }
}
