using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.General
{
    public class Budget
    {
        [Key]
        public int? AccountID { get; set; }
        public string AccountName { get; set; }
        public decimal? BudgetAmt { get; set; }
        public decimal? Spent { get; set; }
        public decimal? CurrentAmt { get; set; }
        public decimal? BalanceAmt { get; set; }
    }
}
