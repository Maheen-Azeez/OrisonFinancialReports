using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class FlightChartingVw
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public int Ccid { get; set; }
        public int AccountId { get; set; }
        public DateTime? DeptDate { get; set; }
        public DateTime? DeptTime { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string GroundTime { get; set; }
        public short? TotalPassanger { get; set; }
        public string Status { get; set; }
        public DateTime? Date { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int? DeptAirportId { get; set; }
        public int? ArrivalAirportId { get; set; }
        public decimal? Rate { get; set; }
        public string Remarks { get; set; }
        public int? StaffNetMinute { get; set; }
        public int? NetMinute { get; set; }
        public decimal? Amount { get; set; }
        public string NetTime { get; set; }
        public string StaffNetTime { get; set; }
        public int? Cargo { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string ArrCode { get; set; }
        public string ArrName { get; set; }
    }
}
