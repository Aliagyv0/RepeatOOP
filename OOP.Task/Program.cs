using OOP.Task.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            Console.WriteLine("Cevrenin sahesi :"+" "+circle.Area());

            Rectangle rectangle = new Rectangle(5, 8);
            Console.WriteLine("Duzbucaqlinin sahesi :" +" " + rectangle.Area());
           

        }
    }
}
