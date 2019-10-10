using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Model
{
    class PacientAuth : IAuthProfile
    {
        [Key]
        [ForeignKey("Pacient")]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Pacient Pacient { get; set; }
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
            return "pacient";
        }
    }
}
