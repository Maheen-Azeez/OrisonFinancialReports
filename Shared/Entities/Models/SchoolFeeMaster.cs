﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SchoolFeeMaster
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? PriorityNo { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Remarks { get; set; }
        public int PostTo { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? DiscountPossible { get; set; }
        public string Type { get; set; }
        public decimal? Amount { get; set; }
        public bool? DateChecking { get; set; }
        public string AcademicYear { get; set; }
        public int? Discount { get; set; }
        public string ReceiptType { get; set; }
        public string DiscountType { get; set; }

        public virtual Account PostToNavigation { get; set; }
    }
}
