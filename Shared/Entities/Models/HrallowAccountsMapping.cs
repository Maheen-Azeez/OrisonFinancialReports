using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrallowAccountsMapping
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public string Category { get; set; }
    }
}
