using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HremployeeContractDetail
    {
        public int Id { get; set; }
        public int? Cid { get; set; }
        public int? TermsId { get; set; }
        public string Terms { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public virtual HremployeeContract CidNavigation { get; set; }
    }
}
