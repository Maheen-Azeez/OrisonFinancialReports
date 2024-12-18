using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EssitemRequest
    {
        public int Id { get; set; }
        public int? RefNo { get; set; }
        public int? EmpId { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public string ItemDescription { get; set; }
    }
}
