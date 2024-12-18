using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmobilizationList
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime Date { get; set; }
        public string Idno { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Nationality { get; set; }
        public string PassportNo { get; set; }
        public int? ProjectId { get; set; }
    }
}
