using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Authentication
{
    public class AddUserDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}