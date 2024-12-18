using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtransportationTran
    {
        public int Id { get; set; }
        public string VehicleNo { get; set; }
        public string Type { get; set; }
        public int? MlkIdno { get; set; }
        public DateTime? MlkIssueDate { get; set; }
        public DateTime? MlkRenewalDate { get; set; }
        public DateTime? MlkExpiryDate { get; set; }
        public string MlkStatus { get; set; }
        public string PolicyNo { get; set; }
        public string InsCompany { get; set; }
        public decimal? InsAmount { get; set; }
        public string InsStatus { get; set; }
        public DateTime? InsExpiryDate { get; set; }
        public DateTime? InsIssueDate { get; set; }
        public string Class { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string ServiceNo { get; set; }
        public string Kilometer { get; set; }
        public string NextKm { get; set; }
        public DateTime? NextDate { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
        public string SrvStatus { get; set; }

        public virtual HrtransportationMast VehicleNoNavigation { get; set; }
    }
}
