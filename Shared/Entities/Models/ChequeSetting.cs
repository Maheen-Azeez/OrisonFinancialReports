using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ChequeSetting
    {
        public ChequeSetting()
        {
            ChequeBanks = new HashSet<ChequeBank>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string ChequeName { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public bool? LandScape { get; set; }
        public string DateFormat { get; set; }
        public string DateSeparator { get; set; }
        public string FieldSettings { get; set; }
        public short? Casing { get; set; }
        public string VarField1 { get; set; }
        public string VarFiled2 { get; set; }
        public string VarFiled3 { get; set; }
        public decimal? NumField1 { get; set; }
        public decimal? NumField2 { get; set; }
        public decimal? NumField3 { get; set; }

        public virtual ICollection<ChequeBank> ChequeBanks { get; set; }
    }
}
