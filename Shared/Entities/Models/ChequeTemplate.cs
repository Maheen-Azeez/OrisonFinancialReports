using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ChequeTemplate
    {
        public ChequeTemplate()
        {
            ChequeTemplateLabes = new HashSet<ChequeTemplateLabe>();
        }

        public int Id { get; set; }
        public string TemplateName { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal LeftMargin { get; set; }
        public decimal RightMargin { get; set; }
        public decimal TopMargin { get; set; }
        public decimal BottomMargin { get; set; }
        public string DateFormat { get; set; }

        public virtual ICollection<ChequeTemplateLabe> ChequeTemplateLabes { get; set; }
    }
}
