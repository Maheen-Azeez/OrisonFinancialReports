using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Models
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Requestor { get; set; }
        //public List<Microsoft.AspNetCore.Http.IFormFile> Attachments { get; set; }
    }
}
