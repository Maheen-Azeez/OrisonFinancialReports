using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TourismClientMaster
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string CustomerNameArab { get; set; }
        public string Address { get; set; }
        public string Pobxno { get; set; }
        public string Location { get; set; }
        public string OfficeNo { get; set; }
        public string Email { get; set; }
        public DateTime? StartingDate { get; set; }
        public string ContactPerson { get; set; }
        public string RefMobile { get; set; }
        public string RefEmail { get; set; }
        public string Remarks { get; set; }
        public string Pdcremarks { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime? Date { get; set; }
    }
}
