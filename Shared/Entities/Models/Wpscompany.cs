using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Wpscompany
    {
        public int Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string EmployerUid { get; set; }
        public string EmployerBcode { get; set; }
        public DateTime? FileCdate { get; set; }
        public string FileCtime { get; set; }
        public string Currency { get; set; }
        public string EmployerRef { get; set; }
    }
}
