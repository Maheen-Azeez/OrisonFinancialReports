﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.General
{
    public class MenuMasterData
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public int? Approval { get; set; }
        public string Keyword { get; set; }
        public string href { get; set; }
        public string ImportSource { get; set; }
        public int? Active { get; set; }
        public bool Hidden { get; set; }
        public int? BranchID { get; set; }
        public int? SortOrder { get; set; }
        public string IconCSS { get; set; }
        public int? Count { get; set; }
        public bool HasChild { get; set; }
        public int? ParentID { get; set; }
    }
}
