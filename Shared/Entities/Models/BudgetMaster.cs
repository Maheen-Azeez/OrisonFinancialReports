using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class BudgetMaster
    {
        public BudgetMaster()
        {
            BudgetTrans = new HashSet<BudgetTran>();
        }

        public int Id { get; set; }
        public string BudgetNo { get; set; }
        public DateTime Date { get; set; }
        public string Mode { get; set; }
        public DateTime EntryDate { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string FinancialYear { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<BudgetTran> BudgetTrans { get; set; }
    }
}
