using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UsersBranch
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public bool Permission { get; set; }

        public virtual Company Branch { get; set; }
        public virtual User User { get; set; }
    }
}
