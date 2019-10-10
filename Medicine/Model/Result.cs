using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Model
{
    class Result
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Opinion { get; set; }
        public int PacientId { get; set; }
        public Pacient Pacient { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int MedServiceId { get; set; }
        public MedService MedService { get; set; }

    }
}
