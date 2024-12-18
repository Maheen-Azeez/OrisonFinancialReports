using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class BranchDyndnsDetail
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string Branch { get; set; }
        public string BranchServer { get; set; }
        public string Dbname { get; set; }
    }
}
