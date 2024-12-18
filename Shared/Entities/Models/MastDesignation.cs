using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class MastDesignation
    {
        public MastDesignation()
        {
            HrcampAttendances = new HashSet<HrcampAttendance>();
            HrempExperiences = new HashSet<HrempExperience>();
            HrempProjectTrans = new HashSet<HrempProjectTran>();
            HremployeeBackups = new HashSet<HremployeeBackup>();
            HrinvoiceDetails = new HashSet<HrinvoiceDetail>();
            Hrmobilizations = new HashSet<Hrmobilization>();
            HrrateMasterMeterSquares = new HashSet<HrrateMasterMeterSquare>();
            HrsupplierInvoiceDetails = new HashSet<HrsupplierInvoiceDetail>();
            HrtimeCardDetails = new HashSet<HrtimeCardDetail>();
            HrtimeCardMeterSquares = new HashSet<HrtimeCardMeterSquare>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public virtual ICollection<HrcampAttendance> HrcampAttendances { get; set; }
        public virtual ICollection<HrempExperience> HrempExperiences { get; set; }
        public virtual ICollection<HrempProjectTran> HrempProjectTrans { get; set; }
        public virtual ICollection<HremployeeBackup> HremployeeBackups { get; set; }
        public virtual ICollection<HrinvoiceDetail> HrinvoiceDetails { get; set; }
        public virtual ICollection<Hrmobilization> Hrmobilizations { get; set; }
        public virtual ICollection<HrrateMasterMeterSquare> HrrateMasterMeterSquares { get; set; }
        public virtual ICollection<HrsupplierInvoiceDetail> HrsupplierInvoiceDetails { get; set; }
        public virtual ICollection<HrtimeCardDetail> HrtimeCardDetails { get; set; }
        public virtual ICollection<HrtimeCardMeterSquare> HrtimeCardMeterSquares { get; set; }
    }
}
