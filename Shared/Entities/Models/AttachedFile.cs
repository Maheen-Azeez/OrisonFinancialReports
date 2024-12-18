using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AttachedFile
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public string FileName { get; set; }

        public virtual DocumentDetail Doc { get; set; }
    }
}
