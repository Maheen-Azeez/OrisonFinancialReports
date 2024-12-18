using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrwpsmaster
    {
        public Hrwpsmaster()
        {
            Hrwpstrans = new HashSet<Hrwpstran>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public string Branch { get; set; }
        public int? PostId { get; set; }
        public int? CashPostId { get; set; }

        public virtual HrbranchSetting BranchNavigation { get; set; }
        public virtual ICollection<Hrwpstran> Hrwpstrans { get; set; }
    }
}
