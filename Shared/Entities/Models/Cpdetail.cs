using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Cpdetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Cpname { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }

        public virtual Account Parent { get; set; }
    }
}
