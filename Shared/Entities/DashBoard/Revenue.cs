using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.DashBoard
{
    public class Revenue
    {
        public string SchoolCode { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int AccountID { get; set; }
        public double Balance { get; set; }
        public Revenue()
        {

        }
    }
}
