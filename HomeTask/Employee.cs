using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTask
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public Guid EmployeeId { get; set; }

        public virtual double CalculateMonthlySalary()
        {
            return 0;
        }
        public abstract void DisplayEmployeeDetails();

        //Task 15 : Task Description:
        //Create an abstract class called Employee with the following specifications:
        //Properties:
        //Name
        //EmployeeId
        //Methods:
        //abstract double CalculateMonthlySalary();
        //abstract void DisplayEmployeeDetails();
        //Create two derived classes, FullTimeEmployee and ContractEmployee, that inherit from Employee and implement the abstract methods.

        //        Implementation Details:
        //Derived Class: FullTimeEmployee
        //Inherits from Employee.
        //Adds a new property AnnualSalary.
        //Implements the CalculateMonthl


    }
}
