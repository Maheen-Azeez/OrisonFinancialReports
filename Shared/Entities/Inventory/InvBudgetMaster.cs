using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{
    public class InvBudgetMaster
    {
        public int Id { get; set; }
        public string BudgetNo { get; set; }
        public DateTime Date { get; set; }
        public string Mode { get; set; }
        public DateTime EntryDate { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string FinancialYear { get; set; }
        public int? Year { get; set; }
        public int BranchID { get; set; }
    }
}
