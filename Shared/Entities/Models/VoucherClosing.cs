using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherClosing
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool Allowed { get; set; }
        public DateTime? Date { get; set; }
    }
}
