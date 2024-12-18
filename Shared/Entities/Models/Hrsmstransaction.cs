using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrsmstransaction
    {
        public int Id { get; set; }
        public int Smsid { get; set; }
        public bool? Status { get; set; }
        public int AccountId { get; set; }
        public string Mobile { get; set; }
        public string Response { get; set; }
    }
}
