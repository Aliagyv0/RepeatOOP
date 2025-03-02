using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task2
{
    //2)Task: Define an interface IVehicle with a property Speed of type int. Implement this interface in a class Car with a constructor that sets the speed and a method to display the speed.
    internal class Car : IVehicle
    {
        public int Speed { get; set; }
        

        public Car(int speed)
        {
            Speed = speed;
        }
        public void ShowSpeed()
        {
            Console.WriteLine(Speed);
        }
    }
}
