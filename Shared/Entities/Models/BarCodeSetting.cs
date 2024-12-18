using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class BarCodeSetting
    {
        public string String { get; set; }
        public bool IsFixed { get; set; }
        public string FieldName { get; set; }
        public int? Id { get; set; }
    }
}
