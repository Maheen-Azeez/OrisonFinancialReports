using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Famaster
    {
        public Famaster()
        {
            Fatrans = new HashSet<Fatran>();
        }

        public int Id { get; set; }
        public string AssetNo { get; set; }
        public string Description { get; set; }
        public string AssetGroup { get; set; }
        public string AssetCategory { get; set; }
        public string SubCategoryCode { get; set; }
        public string DeprType { get; set; }
        public double? DeprPerYear { get; set; }
        public decimal? DeprMinValue { get; set; }
        public decimal? AssetValue { get; set; }
        public int? AssetLife { get; set; }
        public int? AssetAccountId { get; set; }
        public int? DeprAccountId { get; set; }
        public int? VendorAccountId { get; set; }
        public int? AccDeprAccountId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public byte[] Image { get; set; }
        public string Status { get; set; }
        public string PostingMethod { get; set; }
        public string PartNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedUser { get; set; }
        public int? ModifiedUser { get; set; }
        public DateTime? DtField1 { get; set; }
        public DateTime? DtField2 { get; set; }
        public DateTime? DtField3 { get; set; }
        public string TxtField1 { get; set; }
        public string TxtField2 { get; set; }
        public string TxtField3 { get; set; }

        public virtual Account AssetAccount { get; set; }
        public virtual Account DeprAccount { get; set; }
        public virtual Account VendorAccount { get; set; }
        public virtual ICollection<Fatran> Fatrans { get; set; }
    }
}
