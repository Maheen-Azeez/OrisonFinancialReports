using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrwagesAllView
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public decimal? Basic { get; set; }
        public decimal? NormalOtHrs { get; set; }
        public decimal? HolidayOtHrs { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Others { get; set; }
        public decimal? Allowance { get; set; }
        public decimal? Transportation { get; set; }
        public decimal? Accomodation { get; set; }
        public decimal? Telephone { get; set; }
    }
}
