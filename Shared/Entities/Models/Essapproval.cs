using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Essapproval
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public int? Approver { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public bool? Approved { get; set; }
        public string ItemDescription { get; set; }
    }
}
