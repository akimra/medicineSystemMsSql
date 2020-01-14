using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Model
{
    public class MedOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Phone { get; set; }

        public ICollection<Doctor> Doctors;

        public MedOrganization()
        {
            Doctors = new List<Doctor>();
        }
    }
}
