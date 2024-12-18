using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class PersonnelDetailsTran
    {
        public PersonnelDetailsTran()
        {
            Personeldetailstran2s = new HashSet<Personeldetailstran2>();
        }

        public int Pid { get; set; }
        public int AccountId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Pbno { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ContactPerson { get; set; }
        public string ConPersonPhone { get; set; }
        public string ConPersonAddress { get; set; }
        public string ConPersonRelation { get; set; }
        public int? Emirates { get; set; }
        public string City { get; set; }
        public int? Area { get; set; }
        public string Category { get; set; }
        public decimal? Rate { get; set; }
        public int? DesignationId { get; set; }
        public string Department { get; set; }
        public string Nationality { get; set; }
        public string Remarks { get; set; }
        public string Country { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? StaffId { get; set; }
        public bool? AllowCredit { get; set; }
        public short? CreditDays { get; set; }
        public decimal? CreditLimit { get; set; }
        public string CustomerGroup { get; set; }
        public string Price { get; set; }
        public decimal? ContractAmount { get; set; }
        public int? ProjectId { get; set; }
        public string OfficialEmail { get; set; }
        public string Trnno { get; set; }
        public string Ernno { get; set; }
        public string Vatplace { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Personeldetailstran2> Personeldetailstran2s { get; set; }
    }
}
