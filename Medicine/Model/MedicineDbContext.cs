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
    class ContextInitializer : DropCreateDatabaseAlways<MedicineDbContext>
    {
        public string GetHash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hash);
            }
        }
        protected override void Seed(MedicineDbContext db)
        {
            Administrator admin = new Administrator
            {
                Login = "admin",
                Password = GetHash("admin")
            };
            MedOrganization org = new MedOrganization
            {
                Name = "Центр медицинской профилактики",
                Director = "Петров Петр Петрович",
                Phone = "9379992"
            };
            Doctor doc = new Doctor
            {
                Speciality = "Хирург",
                Fio = "Иванов Иван Иванович",
                Room = 31,
                MedOrganization = org,
                Auth = new DoctorAuth
                {
                    Login = "doc",
                    Password = GetHash("doc")
                }
            };
            Pacient pac = new Pacient
            {
                Fio = "Алексеев Алексей Алексеевич",
                Passport = "111111",
                Oms = "123456789",
                Phone = "+79991231212",
                Address = "Navy st., 12",
                Job = "GBU ICEP",
                Position = "Engineer",
                Auth = new PacientAuth
                {
                    Login = "pac",
                    Password = GetHash("pac")
                }
            };
            db.Pacients.Add(pac);
            db.Administrators.Add(admin);
            db.MedOrganizations.Add(org);
            db.Doctors.Add(doc);
            db.SaveChanges();
        }
    }
    class MedicineDbContext : DbContext
    {
        public MedicineDbContext() : base("medicinedb")
        {
            Database.SetInitializer<MedicineDbContext> (new ContextInitializer());
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
