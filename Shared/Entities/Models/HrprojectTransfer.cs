using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrprojectTransfer
    {
        public HrprojectTransfer()
        {
            HrempProjectTrans = new HashSet<HrempProjectTran>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? FromDate { get; set; }
        public string ToProject { get; set; }

        public virtual ICollection<HrempProjectTran> HrempProjectTrans { get; set; }
    }
}
