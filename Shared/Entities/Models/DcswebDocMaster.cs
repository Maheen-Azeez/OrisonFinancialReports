using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebDocMaster
    {
        public DcswebDocMaster()
        {
            DcswebDocument1s = new HashSet<DcswebDocument1>();
        }

        public int DocId { get; set; }
        public string RefNo { get; set; }
        public string RegNo { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int? ReceivedBy { get; set; }
        public string Department { get; set; }
        public int? PartyId { get; set; }
        public string Keywords { get; set; }
        public int? ContactPerson { get; set; }
        public string MobNo { get; set; }
        public string Phone { get; set; }
        public string VolNo { get; set; }
        public string FileLocation { get; set; }
        public string Mode { get; set; }
        public string DocType { get; set; }
        public int? UserId { get; set; }

        public virtual ICollection<DcswebDocument1> DcswebDocument1s { get; set; }
    }
}
