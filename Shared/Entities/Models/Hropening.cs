using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hropening
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string OpeningType { get; set; }
        public decimal? Opening { get; set; }
        public DateTime? OpeningDate { get; set; }
    }
}
