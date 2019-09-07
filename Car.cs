using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPandInheritance
{
    class Car : Vehicle
    {
        private string owner;
        public Car(int doors, string model) : base(doors, model)
        {
        }

        public override void saySomething() //now we use the word override, if we didint use the virtual keyword we wouldnt have beena ble to do this
        {
            //base.saySomething();
            Console.WriteLine("I am in Car class");
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value;}
        }
    }
}
