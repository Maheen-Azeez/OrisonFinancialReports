using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcsDocUser
    {
        public int Id { get; set; }
        public int DocMastId { get; set; }
        public int? UserId { get; set; }
        public string GroupId { get; set; }
    }
}
