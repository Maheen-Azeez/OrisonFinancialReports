using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.General
{
    public class LoginModel : Login
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

    }
}
