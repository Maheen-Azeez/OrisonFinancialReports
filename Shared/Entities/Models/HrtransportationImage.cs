using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtransportationImage
    {
        public int Id { get; set; }
        public string Vehicleno { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }

        public virtual HrtransportationMast VehiclenoNavigation { get; set; }
    }
}
