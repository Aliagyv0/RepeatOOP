using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Part1Task.Task1
{
    public class Circle
    {
        public float Radius;
        public const double Pi = 3.14;

        public void Calculatecircle(float radius)
        {
            double S = Pi*radius*radius;
            Console.WriteLine(S);
        }
    }
}
