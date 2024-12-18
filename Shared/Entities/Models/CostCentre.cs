using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CostCentre
    {
        public CostCentre()
        {
            BudgetCostCentres = new HashSet<BudgetCostCentre>();
            Dcsaccounts = new HashSet<Dcsaccount>();
            EstimateProjects = new HashSet<EstimateProject>();
            HrcampAttendances = new HashSet<HrcampAttendance>();
            HrempLeaveDetails = new HashSet<HrempLeaveDetail>();
            HrempProjectTrans = new HashSet<HrempProjectTran>();
            HrempProjects = new HashSet<HrempProject>();
            Hrmobilizations = new HashSet<Hrmobilization>();
            HrprojectAttendances = new HashSet<HrprojectAttendance>();
            HrtimeCardDetails = new HashSet<HrtimeCardDetail>();
            HrtimeCardMeterSquares = new HashSet<HrtimeCardMeterSquare>();
            HrtimeSheetConsolidateds = new HashSet<HrtimeSheetConsolidated>();
            HrtimeSheetDetails = new HashSet<HrtimeSheetDetail>();
            SalesInvoices = new HashSet<SalesInvoice>();
            TranCostCentres = new HashSet<TranCostCentre>();
            VentryCostCentres = new HashSet<VentryCostCentre>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? InActive { get; set; }
        public string Ptype { get; set; }

        public virtual CostCentreDetail CostCentreDetail { get; set; }
        public virtual ICollection<BudgetCostCentre> BudgetCostCentres { get; set; }
        public virtual ICollection<Dcsaccount> Dcsaccounts { get; set; }
        public virtual ICollection<EstimateProject> EstimateProjects { get; set; }
        public virtual ICollection<HrcampAttendance> HrcampAttendances { get; set; }
        public virtual ICollection<HrempLeaveDetail> HrempLeaveDetails { get; set; }
        public virtual ICollection<HrempProjectTran> HrempProjectTrans { get; set; }
        public virtual ICollection<HrempProject> HrempProjects { get; set; }
        public virtual ICollection<Hrmobilization> Hrmobilizations { get; set; }
        public virtual ICollection<HrprojectAttendance> HrprojectAttendances { get; set; }
        public virtual ICollection<HrtimeCardDetail> HrtimeCardDetails { get; set; }
        public virtual ICollection<HrtimeCardMeterSquare> HrtimeCardMeterSquares { get; set; }
        public virtual ICollection<HrtimeSheetConsolidated> HrtimeSheetConsolidateds { get; set; }
        public virtual ICollection<HrtimeSheetDetail> HrtimeSheetDetails { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
        public virtual ICollection<TranCostCentre> TranCostCentres { get; set; }
        public virtual ICollection<VentryCostCentre> VentryCostCentres { get; set; }
    }
}
