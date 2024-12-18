using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmobilizationMaster
    {
        public HrmobilizationMaster()
        {
            HrmobilizationDetaileds = new HashSet<HrmobilizationDetailed>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? RefDate { get; set; }
        public int? ClientId { get; set; }
        public int? ProjectId { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
        public int? FromProjectId { get; set; }
        public DateTime? FromEnddate { get; set; }

        public virtual ICollection<HrmobilizationDetailed> HrmobilizationDetaileds { get; set; }
    }
}
