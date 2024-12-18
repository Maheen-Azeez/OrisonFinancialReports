using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempTestDetailed
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public string RefNo { get; set; }
        public int? EmpId { get; set; }
        public int? DesignId { get; set; }
        public string TestRemarks { get; set; }
        public string TestResult { get; set; }
    }
}
