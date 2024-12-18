using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class PosVehicle
    {
        public long? Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }
}
