using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class NumberingTran
    {
        public NumberingTran()
        {
            VtypeTrans = new HashSet<VtypeTran>();
        }

        public int Id { get; set; }
        public int? StartingNumber { get; set; }
        public int? MaximumDegits { get; set; }
        public bool? Prefillwithzero { get; set; }
        public int? Renewedby { get; set; }
        public int? Prefix { get; set; }
        public string PrefixValue { get; set; }
        public int? Suffix { get; set; }
        public string SuffixValue { get; set; }
        public bool? Editable { get; set; }

        public virtual FormatMast PrefixNavigation { get; set; }
        public virtual RenewalMast RenewedbyNavigation { get; set; }
        public virtual FormatMast SuffixNavigation { get; set; }
        public virtual ICollection<VtypeTran> VtypeTrans { get; set; }
    }
}
