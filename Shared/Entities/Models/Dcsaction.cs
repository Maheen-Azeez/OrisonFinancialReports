using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Dcsaction
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }

        public virtual Dcsaccount Document { get; set; }
    }
}
