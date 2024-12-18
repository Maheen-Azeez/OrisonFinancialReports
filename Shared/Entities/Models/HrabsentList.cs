using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrabsentList
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime Date { get; set; }
        public int EmpId { get; set; }
        public string Remarks { get; set; }

        public virtual Account Emp { get; set; }
    }
}
