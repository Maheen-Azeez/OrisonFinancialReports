using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EmpDetail
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string MobNo { get; set; }
        public string EmpCode { get; set; }
    }
}
