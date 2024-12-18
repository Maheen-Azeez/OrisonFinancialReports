using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebGroupMember
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }

        public virtual DcswebGroupMaster Group { get; set; }
    }
}
