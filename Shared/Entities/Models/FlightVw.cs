using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class FlightVw
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int DeptAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public string NetTime { get; set; }
        public decimal? Amount { get; set; }
        public string RegNo { get; set; }
        public int Ccid { get; set; }
        public string ArrAirportName { get; set; }
        public string ArrAirportCode { get; set; }
        public string DepAirportCode { get; set; }
        public string DepAirportName { get; set; }
        public decimal? Rate { get; set; }
        public int? NetMinute { get; set; }
        public string SerialNo { get; set; }
        public string RefNo { get; set; }
        public int? StaffNetMinute { get; set; }
    }
}
