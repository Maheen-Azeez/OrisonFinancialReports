﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EstimationAccountsMapping
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
    }
}
