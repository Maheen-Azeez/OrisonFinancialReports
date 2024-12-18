using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HremployeeContract
    {
        public HremployeeContract()
        {
            HremployeeContractDetails = new HashSet<HremployeeContractDetail>();
        }

        public int Id { get; set; }
        public int EmpId { get; set; }
        public string ContractType { get; set; }
        public DateTime ContractDate { get; set; }
        public string ContractFilePath { get; set; }
        public string ContractStatus { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public decimal? BasicSalary { get; set; }

        public virtual ICollection<HremployeeContractDetail> HremployeeContractDetails { get; set; }
    }
}
