﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Entities.General
{
    public partial class AgingDetail
    {
        public int? StartDay { get; set; }
        public int? EndDay { get; set; }
        public int? Priority { get; set; }
        public string Title { get; set; }
    }
}