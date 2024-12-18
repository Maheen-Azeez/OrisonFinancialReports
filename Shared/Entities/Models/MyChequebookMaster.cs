using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class MyChequebookMaster
    {
        public int Id { get; set; }
        public int? Chequebookno { get; set; }
        public string IssueDate { get; set; }
        public int? Chequelfrom { get; set; }
        public int? Chequelto { get; set; }
    }
}
