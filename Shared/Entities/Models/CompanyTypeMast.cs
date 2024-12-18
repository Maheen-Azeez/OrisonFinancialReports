using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CompanyTypeMast
    {
        public CompanyTypeMast()
        {
            Companies = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
