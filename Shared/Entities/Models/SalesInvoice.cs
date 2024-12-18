using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SalesInvoice
    {
        public SalesInvoice()
        {
            SalesInvoiceDetails = new HashSet<SalesInvoiceDetail>();
        }

        public int Id { get; set; }
        public int SalesRepId { get; set; }
        public int RouteId { get; set; }
        public DateTime Sdate { get; set; }
        public string Vno { get; set; }

        public virtual CostCentre Route { get; set; }
        public virtual Account SalesRep { get; set; }
        public virtual ICollection<SalesInvoiceDetail> SalesInvoiceDetails { get; set; }
    }
}
