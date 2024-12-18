using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CallDetail
    {
        public int Id { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public int StaffId { get; set; }
        public string TransferredTo { get; set; }
        public string Description { get; set; }
        public DateTime? CallingDate { get; set; }
        public string Status { get; set; }
    }
}
