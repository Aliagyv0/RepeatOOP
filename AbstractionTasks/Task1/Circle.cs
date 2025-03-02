using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task1
{
    //1)Task: Define an interface IShape with a method GetArea() that returns a double. Implement this interface in a class Circle that has a constructor accepting the radius and calculates the area.
    internal class Circle : IShape
    {
        const double pi = 3.14;
        private double _radius;
        
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Duzgun deyer gonderin");
            }
            _radius = radius;
        }
        public double GetArea()
        {
            double area =  _radius* _radius * pi;
             return area;
         
        }
    }
}
