using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AbstractionTasks.Task4
{
//    Define Parent Interface: 
 
//Create an interface IMovable with a method Move(). 
//Create Derived Interface: 
 
//Create another interface IVehicle that inherits from IMovable and adds a method StartEngine(). 
//Implement Derived Interface: 
 
//Create a class Car that implements IVehicle.Provide implementations for Move() and StartEngine(). 
//Test the Implementation: 
 
//Write a console application that creates an instance of Car, calls StartEngine(), and then calls Move(). 
    internal class Automobile : IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Move metodu isleyir");
        }

        public void StartEngine()
        {
            Console.WriteLine("StartEngine metodu isleyir");
        }
    }
}
