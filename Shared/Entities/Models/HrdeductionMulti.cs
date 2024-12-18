using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdeductionMulti
    {
        public HrdeductionMulti()
        {
            HrdeductionMultidetails = new HashSet<HrdeductionMultidetail>();
        }

        public int Id { get; set; }
        public string Vno { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DedStartdate { get; set; }
        public int? Aid { get; set; }
        public string Deductiontype { get; set; }
        public int? DebitAccount { get; set; }
        public int? CreditAccount { get; set; }
        public int? Instl { get; set; }
        public string Remarks { get; set; }
        public decimal? Total { get; set; }

        public virtual ICollection<HrdeductionMultidetail> HrdeductionMultidetails { get; set; }
    }
}
