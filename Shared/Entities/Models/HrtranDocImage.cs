using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtranDocImage
    {
        public int Id { get; set; }
        public string VehicleNo { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }

        public virtual HrtransportationMast VehicleNoNavigation { get; set; }
    }
}
