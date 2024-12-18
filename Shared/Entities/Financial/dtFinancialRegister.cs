using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class dtFinancialRegister
    {
        public long VID { get; set; }
        public long VEID { get; set; }
        public int ID { get; set; }
        public int AccID { get; set; }
        public DateTime VDate { get; set; }
        public string? VNO { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public string? PAccountCode { get; set; }
        public string? PAccountName { get; set; }
        public string? NameInArabic { get; set; }
        public string? Description { get; set; }
        public string? Currency { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string? RefNo { get; set; }
        public string? Reference { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiededDate { get; set; }
        public string? CreatedUser { get; set; }
        public string? ModifiedUser { get; set; }
        public string? VType { get; set; }
        public string? SID { get; set; }
        public string? StaffName { get; set; }
        public string? Voucheragainst { get; set; }
        public string? CommonNarration { get; set; }
        public int Alloted { get; set; }
    }
}
