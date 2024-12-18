using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Dcsaccount
    {
        public Dcsaccount()
        {
            Dcsactions = new HashSet<Dcsaction>();
            Dcsdocument1s = new HashSet<Dcsdocument1>();
            DcsuserSecurities = new HashSet<DcsuserSecurity>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public int? PartyId { get; set; }
        public int? ProjectId { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string Category { get; set; }
        public int? ReceivedBy { get; set; }
        public string VolNo { get; set; }
        public string FileLocation { get; set; }
        public int? ContactPerson { get; set; }
        public string RegNo { get; set; }
        public string Cc { get; set; }

        public virtual Account Party { get; set; }
        public virtual CostCentre Project { get; set; }
        public virtual ICollection<Dcsaction> Dcsactions { get; set; }
        public virtual ICollection<Dcsdocument1> Dcsdocument1s { get; set; }
        public virtual ICollection<DcsuserSecurity> DcsuserSecurities { get; set; }
    }
}
