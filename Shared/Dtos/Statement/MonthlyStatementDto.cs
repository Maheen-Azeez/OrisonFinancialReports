using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Dtos.Statement
{
    public class MonthlyStatementDto
    {
        public int VID { get; set; }
        public DateTime? Date { get; set; }
        public string? VNo { get; set; }
        public string? AccountName { get; set; }
        public string? Narration { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
