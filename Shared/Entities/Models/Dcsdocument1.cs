using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Dcsdocument1
    {
        public int Id { get; set; }
        public int? Dcsid { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public virtual Dcsaccount Dcs { get; set; }
    }
}
