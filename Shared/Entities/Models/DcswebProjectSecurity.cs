using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebProjectSecurity
    {
        public int Id { get; set; }
        public long? ProjectId { get; set; }
        public int? UserId { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }

        public virtual DcswebProject Project { get; set; }
    }
}
