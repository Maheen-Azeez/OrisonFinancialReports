using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TourismExcursionInvoice
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public DateTime FromDate { get; set; }
        public string VisitorName { get; set; }
        public string HotelName { get; set; }
        public string Excursion { get; set; }
        public int? NoOfPax { get; set; }
        public string Remarks { get; set; }
        public string PickupTime { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal Amount { get; set; }
        public bool? Posted { get; set; }
        public int? PostTo { get; set; }
        public string VoucherId { get; set; }
        public string Type { get; set; }
        public string Refno { get; set; }
        public int? Outsourcerid { get; set; }
        public decimal? Outsourcingamt { get; set; }
        public int? VoucherId2 { get; set; }
        public string Refno2 { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public string Driver { get; set; }

        public virtual Account Account { get; set; }
    }
}
