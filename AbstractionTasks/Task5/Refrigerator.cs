using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task5
{
//    )Interface Inheritance
//Define an interface IAppliance with the following properties: 
//string Brand
//string Model


//Define another interface IHomeAppliance that inherits from IAppliance and adds the following properties: 
//int Power
//string EnergyRating


//Create a class Refrigerator that implements the IHomeAppliance interface.
    internal class Refrigerator : IHomeAppliance
    {
        public int Power { get; set; }
        public string EnergyRaiting { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
