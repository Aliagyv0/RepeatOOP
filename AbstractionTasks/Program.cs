using AbstractionTasks.Task1;
using AbstractionTasks.Task2;
using AbstractionTasks.Task3;
using AbstractionTasks.Task4;
using AbstractionTasks.Task5.Task6;
using AbstractionTasks.Task7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.GetArea();

            Car car = new Car(300);
            car.ShowSpeed();

            MultiFunctionPrinter printer = new MultiFunctionPrinter();
            printer.Scan();
            printer.Print();
            

            Automobile automobile = new Automobile();
            automobile.StartEngine();
            automobile.Move();

            WeatherCondition weather = new WeatherCondition();
            switch (weather)
            {
                case WeatherCondition.Rainy:
                    Console.WriteLine("Hava yagislidi");
                    break;
                case WeatherCondition.Foggy:
                    Console.WriteLine("Hava dumanlidir");
                    break;
                case WeatherCondition.Snowy:
                    Console.WriteLine("Hava qarlidir,berk geyin,altdan finka geyin");
                    break;
                case WeatherCondition.Sunny:
                    Console.WriteLine("Hava gunewlidir");
                    break;
                case WeatherCondition.Cloudy:
                    Console.WriteLine("Hava kuleklidir");
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin !");
                    break;
            }

            TrafficLight trafficLight = new TrafficLight();

            switch (trafficLight)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Dayan");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Hazirlaw");
                    break;
                case TrafficLight.Green:
                    Console.WriteLine("Sur");
                    break;
                default:
                    Console.WriteLine("Dusgun secim edin");
                    break;
            }
        }

    }
}
