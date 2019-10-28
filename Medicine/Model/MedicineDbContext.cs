using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography;
using Medicine.Controller;

namespace Medicine.Model
{
    class MedicineDbContext : DbContext
    {
        public MedicineDbContext() : base("medicinedb")
        {
            
        }

        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedOrganization> MedOrganizations { get; set; }
        public DbSet<MedService> MedServices { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<PacientAuth> PacientAuths { get; set; }
        public DbSet<DoctorAuth> DoctorAuths { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        
    }
}
