using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities
{
    public class Gadget
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public decimal Cost { get; set; }

        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
