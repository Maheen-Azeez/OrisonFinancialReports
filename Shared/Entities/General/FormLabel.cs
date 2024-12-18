using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.General
{
    public class FormLabel
    {
        public int ID { get; set; }
        public string FormName { get; set; }
        public string LabelName { get; set; }
        public string OriginalCaption { get; set; }
        public string NewCaption { get; set; }
        public int Visible { get; set; }
    }
}
