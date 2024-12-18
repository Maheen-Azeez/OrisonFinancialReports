using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProductionDailyMast
    {
        public ProductionDailyMast()
        {
            ProductionDailyTrans = new HashSet<ProductionDailyTran>();
        }

        public long Id { get; set; }
        public string Vno { get; set; }
        public int? Vtype { get; set; }
        public DateTime? Vdate { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<ProductionDailyTran> ProductionDailyTrans { get; set; }
    }
}
