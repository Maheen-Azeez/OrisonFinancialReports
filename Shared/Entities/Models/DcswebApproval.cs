using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebApproval
    {
        public int AppId { get; set; }
        public int MailId { get; set; }
        public int UserId { get; set; }
        public string AppStatus { get; set; }
        public string AppType { get; set; }
    }
}
