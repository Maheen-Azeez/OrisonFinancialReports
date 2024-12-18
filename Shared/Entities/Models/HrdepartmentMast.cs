using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdepartmentMast
    {
        public HrdepartmentMast()
        {
            HremployeeBackups = new HashSet<HremployeeBackup>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<HremployeeBackup> HremployeeBackups { get; set; }
    }
}
