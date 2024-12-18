using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.DashBoard
{
    public class AbsentParent
    {
        //[Key
        public int Id { get; set; }
        public string Row { get; set; }
        //public string ClassName { get; set; }
        //public string Class { get; set; }
        //public string Division { get; set; }
        //public string Section { get; set; }
        public string Datestr { get; set; }
        public DateTime? Date { get; set; }
        //public string Photo { get; set; }
        public string DateTo { get; set; }
        public string Shift { get; set; }
        //public string RegisterNo { get; set; }
        //public string Bus_No { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public string source { get; set; }
        public string Year { get; set; }
        public int AccountID { get; set; }
        //public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public string Reason { get; set; }
        public string Nationality { get; set; }

        public string Religion { get; set; }
        public int branchid { get; set; }

        public string Sex { get; set; }


        //public int POL { get; set; }
        //public int P { get; set; }
        //public int L { get; set; }
        //public int A { get; set; }
        //public int UA { get; set; }
        //public string ProcessedBy { get; set; }
        //public string UserCategory { get; set; }
        //public string ProcessedDate { get; set; }

        //public string Subject1 { get; set; }
        //public string Teacher1 { get; set; }
        //public string Subject2 { get; set; }
        //public string Teacher2 { get; set; }

        //public int? OrderID { get; set; }
        //public string CustomerID { get; set; }
        //public DateTime? OrderDate { get; set; }
        //public double? Freight { get; set; }
        public AbsentParent()
        {

        }
    }
}
