using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task5
{
    internal interface IHomeAppliance:IAppliance
    {
        int Power { get; set; }
        string EnergyRaiting { get; set; }
    }
}
