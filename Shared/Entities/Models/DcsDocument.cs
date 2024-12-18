using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcsDocument
    {
        public int Id { get; set; }
        public int DocMastId { get; set; }
        public byte[] File { get; set; }
        public int Filelength { get; set; }
        public string FileType { get; set; }
        public string Description { get; set; }
    }
}
