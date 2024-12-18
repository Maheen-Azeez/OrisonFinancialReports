using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrleaveImage
    {
        public int Id { get; set; }
        public int Lid { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }

        public virtual HrempLeaveDetail LidNavigation { get; set; }
    }
}
