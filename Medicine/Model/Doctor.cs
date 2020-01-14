using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        public DoctorAuth Auth { get; set; }
        public string Fio { get; set; }
        public string Speciality { get; set; }
        public int Room { get; set; }
        public int MedOrganizationId { get; set; }
        public MedOrganization MedOrganization { get; set; }

        public ICollection<Result> Results { get; set; }

        public Doctor()
        {
            Results = new List<Result>();
        }
    }
}
