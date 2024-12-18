using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ChequeTemplateLabe
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string LabelName { get; set; }
        public string Font { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public bool? Visible { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public int Alignemt { get; set; }

        public virtual ChequeTemplate TemplateNameNavigation { get; set; }
    }
}
