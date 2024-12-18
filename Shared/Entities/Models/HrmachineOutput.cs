using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmachineOutput
    {
        public int Id { get; set; }
        public string EmpCode { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Mode { get; set; }
    }
}
