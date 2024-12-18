using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrinvContract
    {
        public HrinvContract()
        {
            HrinvDeductions = new HashSet<HrinvDeduction>();
            HrinvWorkingProgresses = new HashSet<HrinvWorkingProgress>();
        }

        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public string Project { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string PrevBillNo { get; set; }
        public string Progressive { get; set; }
        public decimal? ContractValue { get; set; }
        public decimal? WorProgTotal { get; set; }
        public decimal? AdvDeduction { get; set; }
        public decimal? Retention { get; set; }
        public decimal? Net { get; set; }
        public decimal? NetReceivable { get; set; }
        public decimal? DedTotal { get; set; }
        public string Remarks { get; set; }
        public string AdvDedDesc { get; set; }
        public string PrevPaymentDesc { get; set; }
        public string NetReceivableDesc { get; set; }
        public string RetentionDesc { get; set; }
        public decimal? PrevPayment { get; set; }

        public virtual ICollection<HrinvDeduction> HrinvDeductions { get; set; }
        public virtual ICollection<HrinvWorkingProgress> HrinvWorkingProgresses { get; set; }
    }
}
