using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EssapproverMaster
    {
        public EssapproverMaster()
        {
            EssapproverTrans = new HashSet<EssapproverTran>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<EssapproverTran> EssapproverTrans { get; set; }
    }
}
