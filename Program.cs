using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is a very simple project, it is just to test the type of polymorphism of the language (I concluded it is dynamic line 25)
 * also, I wanted to test a few advance features like lambda expressions and classes that implement them, as well as genetics and methods
 * from a data structure ( ForEach() ).
 */
namespace OOPandInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(10,"vehicle");

            Car camaro = new Car(2,"Camaro");

            camaro.printModel();
            camaro.Owner = "Robert";
            
            Console.WriteLine(camaro.Owner);

            Vehicle toyota =  new Car(4,"Toyota");
            toyota.printModel();
            toyota.saySomething();

            Garage garageTest = new Garage();
            garageTest.addCar(vehicle);
            garageTest.addCar(camaro);
            garageTest.addCar(toyota);

            
            Action<Vehicle> action = (var) => { var.printModel(); };

            Console.WriteLine("*********  STARTING TEST  **********");
            garageTest.garage.ForEach(action);
        }
    }
}
