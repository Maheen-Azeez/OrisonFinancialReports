using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CardMast
    {
        public CardMast()
        {
            Cheques = new HashSet<Cheque>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal? Commission { get; set; }

        public virtual ICollection<Cheque> Cheques { get; set; }
    }
}
