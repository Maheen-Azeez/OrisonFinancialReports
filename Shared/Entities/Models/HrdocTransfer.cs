using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdocTransfer
    {
        public HrdocTransfer()
        {
            HrdocTranDetails = new HashSet<HrdocTranDetail>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public string RefNo { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<HrdocTranDetail> HrdocTranDetails { get; set; }
    }
}
