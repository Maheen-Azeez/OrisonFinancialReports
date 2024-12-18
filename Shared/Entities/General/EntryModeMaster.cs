using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.General
{
    public class EntryModeMaster
    {
        public int Id { get; set; }
        public string EntryMode { get; set; }
        public int? InitialVtype { get; set; }
        public bool? Active { get; set; }
        public short? SectionOrderNo { get; set; }
        public short? OrderNo { get; set; }
        public string ImportSource { get; set; }
        public string ArabicName { get; set; }
        public bool? Store { get; set; }
        public int? Approval { get; set; }
    }
}
