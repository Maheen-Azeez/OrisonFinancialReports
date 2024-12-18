using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class UserRight
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int KeywordId { get; set; }
        public bool AllowOpen { get; set; }
        public bool AllowAdd { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowPrint { get; set; }
        public bool? AccessDenied { get; set; }

        public virtual UserRightsMaster Keyword { get; set; }
        public virtual User User { get; set; }
    }
}
