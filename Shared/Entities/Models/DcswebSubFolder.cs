using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class DcswebSubFolder
    {
        public int Id { get; set; }
        public int? FolderId { get; set; }
        public string Name { get; set; }
    }
}
