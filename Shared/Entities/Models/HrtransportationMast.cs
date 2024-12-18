using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtransportationMast
    {
        public HrtransportationMast()
        {
            HrtranDocImages = new HashSet<HrtranDocImage>();
            HrtransportationImages = new HashSet<HrtransportationImage>();
            HrtransportationTrans = new HashSet<HrtransportationTran>();
            HrvehicleDocuments = new HashSet<HrvehicleDocument>();
            SchoolStudents = new HashSet<SchoolStudent>();
        }

        public int Id { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public string Plate { get; set; }
        public string Emirates { get; set; }
        public string ChassisNo { get; set; }
        public string EngineNo { get; set; }
        public string Supplier { get; set; }
        public int? Capacity { get; set; }
        public string Remarks { get; set; }
        public string Driver { get; set; }
        public string DriverMobile { get; set; }
        public string Conductor { get; set; }
        public string ConductorMobile { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Route { get; set; }

        public virtual ICollection<HrtranDocImage> HrtranDocImages { get; set; }
        public virtual ICollection<HrtransportationImage> HrtransportationImages { get; set; }
        public virtual ICollection<HrtransportationTran> HrtransportationTrans { get; set; }
        public virtual ICollection<HrvehicleDocument> HrvehicleDocuments { get; set; }
        public virtual ICollection<SchoolStudent> SchoolStudents { get; set; }
    }
}
