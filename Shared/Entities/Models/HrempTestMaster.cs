using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempTestMaster
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public int? ClientId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? Date { get; set; }
        public string Remarks { get; set; }
    }
}
