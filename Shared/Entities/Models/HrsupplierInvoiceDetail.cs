using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrsupplierInvoiceDetail
    {
        public int Id { get; set; }
        public int Iid { get; set; }
        public int? EmpId { get; set; }
        public int DesignId { get; set; }
        public decimal? Nh { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Hot { get; set; }
        public decimal? Nhrate { get; set; }
        public decimal? Otrate { get; set; }
        public decimal? Hotrate { get; set; }
        public decimal? Nhamount { get; set; }
        public decimal? Otamount { get; set; }
        public decimal? Hotamount { get; set; }
        public int? EmpCount { get; set; }
        public decimal? Total { get; set; }
        public decimal? Ih { get; set; }
        public decimal? Itotal { get; set; }

        public virtual MastDesignation Design { get; set; }
        public virtual Account Emp { get; set; }
        public virtual HrsupplierInvoice IidNavigation { get; set; }
    }
}
