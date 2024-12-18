using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EntryModeMast
    {
        public EntryModeMast()
        {
            VtypeTrans = new HashSet<VtypeTran>();
        }

        public int Id { get; set; }
        public string EntryMode { get; set; }
        public int? InitialVtype { get; set; }
        public bool? Active { get; set; }
        public short? SectionOrderNo { get; set; }
        public short? OrderNo { get; set; }
        public string ImportSource { get; set; }
        public string ArabicName { get; set; }
        public bool? Store { get; set; }

        public virtual VtypeMast ImportSourceNavigation { get; set; }
        public virtual VtypeTran InitialVtypeNavigation { get; set; }
        public virtual ICollection<VtypeTran> VtypeTrans { get; set; }
    }
}
