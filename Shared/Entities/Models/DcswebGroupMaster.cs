using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebGroupMaster
    {
        public DcswebGroupMaster()
        {
            DcswebGroupMembers = new HashSet<DcswebGroupMember>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<DcswebGroupMember> DcswebGroupMembers { get; set; }
    }
}
