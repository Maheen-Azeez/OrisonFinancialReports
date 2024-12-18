using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebModuleSecurity
    {
        public int Id { get; set; }
        public long? ProjectId { get; set; }
        public int? UserId { get; set; }
        public int? Status { get; set; }
        public int? CanDelete { get; set; }
        public int? CanView { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public bool? ViewCheck { get; set; }
        public bool? AddCheck { get; set; }
        public bool? EditCheck { get; set; }
        public bool? DeleteCheck { get; set; }
        public bool? PrintCheck { get; set; }

        public virtual DcswebProject Project { get; set; }
    }
}
