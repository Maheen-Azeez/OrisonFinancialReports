using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrprojectInvoiceTran
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int EmpId { get; set; }
        public int DesignationId { get; set; }
        public decimal? Crate { get; set; }
        public decimal? Erate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Hour { get; set; }

        public virtual HrprojectInvoice PidNavigation { get; set; }
    }
}
