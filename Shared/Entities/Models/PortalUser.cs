using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class PortalUser
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Category { get; set; }
        public string Section { get; set; }
        public string Status { get; set; }
        public int? ProfileId { get; set; }
        public string ClassStatus { get; set; }
        public DateTime? Mdate { get; set; }
        public string UserIp { get; set; }

        public virtual Account Account { get; set; }
    }
}
