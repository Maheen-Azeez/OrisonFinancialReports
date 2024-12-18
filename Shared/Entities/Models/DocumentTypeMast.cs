using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DocumentTypeMast
    {
        public DocumentTypeMast()
        {
            VtypeTrans = new HashSet<VtypeTran>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<VtypeTran> VtypeTrans { get; set; }
    }
}
