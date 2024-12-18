using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AccountsImage
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
        public string OriginPath { get; set; }
        public string DocName { get; set; }
        public string CurrentPath { get; set; }

        public virtual Account Account { get; set; }
    }
}
