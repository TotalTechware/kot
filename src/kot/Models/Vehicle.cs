using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kot.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //forign key stuff
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
