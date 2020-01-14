using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Model
{
    public class Administrator : IAuthProfile
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string GetLogin()
        {
            return Login;
        }
        public string GetHashPassword()
        {
            return Password;
        }
        public string GetTypeAuth()
        {
            return "administrator";
        }
    }
}
