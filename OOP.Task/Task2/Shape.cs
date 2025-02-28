using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task.Task2
{
//Task 2 : Create a C# program that demonstrates the concept of abstraction. Follow these steps:
//Create a class called Shape.
//Define an abstract method within the Shape class called area(). 
//Create two subclasses of Shape called Rectangle and Circle.
//Implement the area() method in both Rectangle and Circle classes to calculate the area of a rectangle and a circle, respectively.
//Create objects of both Rectangle and Circle classes and call the area() method for each.
    public abstract class Shape
    {
        public abstract double Area();
       
    }
    public class Rectangle : Shape
    {
        double a;
        double b;
        public Rectangle(double a,double b)
        {
            this.a =a;
            this.b =b;
        }

        public override double Area()
        {
            return a * b;
        }
    }

    public class Circle : Shape
    {
        double r;
        double pi=3.14;
        public Circle(double r)
        {
            this.r =r;
        }

        public override double Area()
        {
           return r*r*pi;
        }
    }
}
