using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TransactionsRemark
    {
        public long Id { get; set; }
        public string Remarks { get; set; }

        public virtual Transaction IdNavigation { get; set; }
    }
}
