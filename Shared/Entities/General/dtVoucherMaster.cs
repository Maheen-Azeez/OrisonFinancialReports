using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.General
{
    public class dtVoucherMaster
    {
        [Key]
        public long ID { get; set; }
        //public int SlNo { get; set; }
        public string VNo { get; set; }
        public int VType { get; set; }
        public decimal? Amount { get; set; }
        public DateTime Vdate { get; set; }
        public bool Posted { get; set; }
        public string RefNo { get; set; }
        public bool? IsCanceled { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NetAmt { get; set; }
        public decimal? VATAmt { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string VNoInt { get; set; }
        public long AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
