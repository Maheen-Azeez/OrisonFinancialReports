using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcsDocMaster
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public string RegNo { get; set; }
        public DateTime Date { get; set; }
        public string PartyId { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Version { get; set; }
        public int? UserId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
