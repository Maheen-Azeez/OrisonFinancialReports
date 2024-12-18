using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ChequeBookTran
    {
        public int Id { get; set; }
        public int? ChequeBookId { get; set; }
        public string LeafNo { get; set; }
        public string Party { get; set; }
        public string ChqStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? Chequedate { get; set; }
        public decimal? Amount { get; set; }
        public int? Field1 { get; set; }
        public int? Field2 { get; set; }
        public string Varfield1 { get; set; }
        public string Varfield2 { get; set; }
        public bool Inactive { get; set; }

        public virtual ChequeBookMaster ChequeBook { get; set; }
    }
}
