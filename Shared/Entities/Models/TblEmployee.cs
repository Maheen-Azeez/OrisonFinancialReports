﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TblEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
    }
}
