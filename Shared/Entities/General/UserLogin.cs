using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.General
{
    public class UserLogin
    {
        public int UserID { get; set; }
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Category { get; set; }
        public int ProfileID { get; set; }
        public int BranchID { get; set; }
    }
}
