using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmobilizeMaster
    {
        public HrmobilizeMaster()
        {
            Hrmobilizations = new HashSet<Hrmobilization>();
        }

        public int Id { get; set; }
        public string Mobilize { get; set; }
        public decimal? Hour { get; set; }

        public virtual ICollection<Hrmobilization> Hrmobilizations { get; set; }
    }
}
