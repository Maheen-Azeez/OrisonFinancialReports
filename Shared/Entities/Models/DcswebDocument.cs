using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebDocument
    {
        public DcswebDocument()
        {
            DcswebDocTracks = new HashSet<DcswebDocTrack>();
            DcswebOldDocuments = new HashSet<DcswebOldDocument>();
        }

        public long Id { get; set; }
        public long? FolderId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Size { get; set; }
        public decimal? Version { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUser { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Client { get; set; }
        public long? DocNo { get; set; }
        public int? VerifiedUser { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public DateTime? Expirydate { get; set; }
        public double? Amount { get; set; }
        public string RefNo { get; set; }
        public DateTime? Startdate { get; set; }
        public string Remarks { get; set; }
        public string ProgressStatus { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public DateTime? Sendon { get; set; }
        public string Paymenttype { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string ContactPerson { get; set; }
        public string Supplier { get; set; }
        public DateTime? DateofDelivery { get; set; }
        public DateTime? DateofReceiving { get; set; }
        public string MaterialReceivedBy { get; set; }
        public DateTime? DateofPayment { get; set; }
        public string ChequeNo { get; set; }
        public string RefdelNote { get; set; }
        public string Followby { get; set; }
        public string RefLpo { get; set; }
        public DateTime? DateReceived { get; set; }

        public virtual DcswebDocFolder Folder { get; set; }
        public virtual ICollection<DcswebDocTrack> DcswebDocTracks { get; set; }
        public virtual ICollection<DcswebOldDocument> DcswebOldDocuments { get; set; }
    }
}
