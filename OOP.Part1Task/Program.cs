using OOP.Part1Task.Task1;
using OOP.Part1Task.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Part1Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Calculatecircle(3);

            Person Ali = new Person("Ali","Agayev",17);
            Person Nijat = new Person("Nijat","Soltanov",21);
            Ali.Info();
            Nijat.Info();
        }
    }
}
