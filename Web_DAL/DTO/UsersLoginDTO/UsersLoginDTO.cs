using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_DTO.DTO.UsersLoginDTO
{
    public class UsersLoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RememberMe { get; set; }
        public string ReturnUrl { get; set; }

    }
}
