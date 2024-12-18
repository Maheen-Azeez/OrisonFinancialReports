using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CustomRegister
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public string RegisterName { get; set; }
        public string DefaultCriteria { get; set; }
        public string ReportFileName { get; set; }
        public string CmdText { get; set; }
        public string ColSettings { get; set; }
        public string ParamSettings { get; set; }
    }
}
