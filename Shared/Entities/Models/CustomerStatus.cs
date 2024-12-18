using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CustomerStatus
    {
        public int Id { get; set; }
        public int? CustId { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }

        public virtual Account Cust { get; set; }
    }
}
