using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Model
{
    public enum ServiceType
    {
        Inspect = 1,
        Laboratory = 2
    }
    public class MedService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ServiceType Type { get; set; }
        public int Price { get; set; }
        public ICollection<Result> Results { get; set; }

        public MedService()
        {
            Results = new List<Result>();
        }
    }
}
