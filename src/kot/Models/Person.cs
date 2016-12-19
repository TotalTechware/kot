using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kot.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
