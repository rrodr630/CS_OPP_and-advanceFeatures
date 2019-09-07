using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPandInheritance
{
    class Vehicle
    {
        private int doors;
        private string model;

        public Vehicle(int doors, string model)
        {
            this.doors = doors;
            this.model = model;
        }

        public void printModel() { Console.WriteLine(model); }

        public virtual void saySomething() { Console.WriteLine("I am in Vehicle class"); } //virtual key word is used to make methods overrideable

        public int Doors
        {
            get { return doors; }
            set { doors = value;}
        }

    }
}
