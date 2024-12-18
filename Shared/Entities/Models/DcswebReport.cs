using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebReport
    {
        public long Id { get; set; }
        public long? FolderId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Size { get; set; }
        public string Projectno { get; set; }
        public string Desc { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Compdate { get; set; }
        public double? Contractsum { get; set; }
        public string Variations { get; set; }
        public string Deductions { get; set; }
        public string Retentions { get; set; }
        public string Performance { get; set; }
        public double? Amount { get; set; }
        public string Material { get; set; }
        public string Subcontract { get; set; }
        public double? Salary { get; set; }
        public string Equipment { get; set; }
        public string Petrol { get; set; }
        public string Overhead { get; set; }
        public string Misc { get; set; }
        public string Totalexp { get; set; }
        public string Profit { get; set; }
        public string Modifieduser { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string Verifieduser { get; set; }
        public long? DocNo { get; set; }

        public virtual DcswebDocFolder Folder { get; set; }
    }
}
