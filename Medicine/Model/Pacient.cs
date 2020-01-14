using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Model
{
    public class Pacient
    {
        public int Id { get; set; }
        public PacientAuth Auth { get; set; }
        public string Fio { get; set; }
        public string Passport { get; set; }
        public string Oms { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public string Position { get; set; }

        public ICollection<Result> Results { get; set; }

        public Pacient()
        {
            Results = new List<Result>();
        }
    }
}
