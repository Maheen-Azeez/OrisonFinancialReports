using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class FormatMast
    {
        public FormatMast()
        {
            NumberingTranPrefixNavigations = new HashSet<NumberingTran>();
            NumberingTranSuffixNavigations = new HashSet<NumberingTran>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Temp { get; set; }

        public virtual ICollection<NumberingTran> NumberingTranPrefixNavigations { get; set; }
        public virtual ICollection<NumberingTran> NumberingTranSuffixNavigations { get; set; }
    }
}
