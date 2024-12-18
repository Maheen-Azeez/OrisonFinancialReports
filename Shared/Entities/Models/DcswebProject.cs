using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebProject
    {
        public DcswebProject()
        {
            DcswebDocFolders = new HashSet<DcswebDocFolder>();
            DcswebModuleSecurities = new HashSet<DcswebModuleSecurity>();
            DcswebProjectSecurities = new HashSet<DcswebProjectSecurity>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public string Logo { get; set; }
        public int? OrganizationId { get; set; }
        public string Client { get; set; }
        public string Status { get; set; }

        public virtual ICollection<DcswebDocFolder> DcswebDocFolders { get; set; }
        public virtual ICollection<DcswebModuleSecurity> DcswebModuleSecurities { get; set; }
        public virtual ICollection<DcswebProjectSecurity> DcswebProjectSecurities { get; set; }
    }
}
