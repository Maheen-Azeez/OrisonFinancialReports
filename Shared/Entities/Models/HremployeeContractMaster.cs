using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HremployeeContractMaster
    {
        public int Id { get; set; }
        public string Terms { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int? OrderNo { get; set; }
    }
}
