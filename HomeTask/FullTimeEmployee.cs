using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    public class FullTimeEmployee : Employee
    {
        public float AnnualSalary {  get; set; }
        public override double CalculateMonthlySalary()
        {
            float monthlySalary = AnnualSalary/12;
            return monthlySalary;
        }

        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Ad:{Name}");
            Console.WriteLine($"IllikMaas:{AnnualSalary}");
            Console.WriteLine($"Id:{EmployeeId}");

        }
    }
}
