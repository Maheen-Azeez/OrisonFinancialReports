using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ChequeBookMaster
    {
        public ChequeBookMaster()
        {
            ChequeBookTrans = new HashSet<ChequeBookTran>();
        }

        public int Id { get; set; }
        public string ChequeBookNo { get; set; }
        public int? BankId { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? ChequeLeafFrom { get; set; }
        public int? ChequeLeafTo { get; set; }
        public int? Field1 { get; set; }
        public int? Field2 { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }

        public virtual Account Bank { get; set; }
        public virtual ICollection<ChequeBookTran> ChequeBookTrans { get; set; }
    }
}
