using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrattendanceStation
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public string Path { get; set; }
        public string Value { get; set; }

        public virtual Company Branch { get; set; }
    }
}
