using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DynamicAccount
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
