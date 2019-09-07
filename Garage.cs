using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPandInheritance
{
    class Garage
    {
        public List<Vehicle> garage;

        public Garage()
        {
            garage = new List<Vehicle>();
        }

        public void addCar(Vehicle car) { garage.Add(car); }
    }
}
