using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class FlightChartingDetailsVw
    {
        public int Id { get; set; }
        public int Fcid { get; set; }
        public int AccountId { get; set; }
        public int DesignationId { get; set; }
        public decimal Rate { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
    }
}
