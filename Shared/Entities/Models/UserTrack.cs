using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UserTrack
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public string TableName { get; set; }
        public DateTime ActionDate { get; set; }
        public string Reason { get; set; }
        public int? ActionId { get; set; }
        public long? RowId { get; set; }
        public string MachineName { get; set; }
        public string ModuleName { get; set; }
        public string Reference { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Vdate { get; set; }
        public int? AccountId { get; set; }
        public string PartyName { get; set; }
        public string Remarks { get; set; }
        public decimal? OldAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public string Version { get; set; }
        public string Accountcode { get; set; }
    }
}
