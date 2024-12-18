using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{
    public class dtInvVoucherStatus
    {
        [Key]
        public long ID { get; set; }
        public long VID { get; set; }
        public int UserID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }
        public int? RVID { get; set; }
        public string ApproverID { get; set; }
        public string Approver { get; set; }
        public string Remarks { get; set; }
        public string Remarks2 { get; set; }
        public string NextApproverID { get; set; }
        public string NextApprover { get; set; }
        public int? ApproverLevel { get; set; }
        public int? NextLevel { get; set; }
        
        public string BranchID { get; set; }
        public string Keyword { get; set; }
        
    }
}
