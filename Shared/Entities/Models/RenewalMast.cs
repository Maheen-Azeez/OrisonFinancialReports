using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class RenewalMast
    {
        public RenewalMast()
        {
            NumberingTrans = new HashSet<NumberingTran>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<NumberingTran> NumberingTrans { get; set; }
    }
}
