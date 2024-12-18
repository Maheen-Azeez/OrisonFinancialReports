using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrcampMaster
    {
        public int Id { get; set; }
        public string CampCode { get; set; }
        public string CampName { get; set; }
        public int? TotalRoom { get; set; }
        public int? Capacity { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
