using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Personeldetailstran2
    {
        public int Id { get; set; }
        public int Accountid { get; set; }
        public int? Pid { get; set; }
        public string Contactperson { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }

        public virtual Account Account { get; set; }
        public virtual PersonnelDetailsTran PidNavigation { get; set; }
    }
}
