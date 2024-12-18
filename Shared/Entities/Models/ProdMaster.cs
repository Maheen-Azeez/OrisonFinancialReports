using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProdMaster
    {
        public ProdMaster()
        {
            ProdExpenses = new HashSet<ProdExpense>();
            ProdFinishedItems = new HashSet<ProdFinishedItem>();
            ProdManpowerMasters = new HashSet<ProdManpowerMaster>();
            ProdMaterials = new HashSet<ProdMaterial>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int ModifiedUserId { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public string VarField3 { get; set; }
        public decimal? NumField1 { get; set; }
        public decimal? NumField2 { get; set; }
        public decimal? NumField3 { get; set; }

        public virtual ICollection<ProdExpense> ProdExpenses { get; set; }
        public virtual ICollection<ProdFinishedItem> ProdFinishedItems { get; set; }
        public virtual ICollection<ProdManpowerMaster> ProdManpowerMasters { get; set; }
        public virtual ICollection<ProdMaterial> ProdMaterials { get; set; }
    }
}
