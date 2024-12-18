using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcsuserSecurity
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int UserId { get; set; }
        public bool? Show { get; set; }
        public bool? Modify { get; set; }
        public bool? Print { get; set; }
        public bool? Browse { get; set; }
        public bool? Mail { get; set; }

        public virtual Dcsaccount Document { get; set; }
        public virtual User User { get; set; }
    }
}
