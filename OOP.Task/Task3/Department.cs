using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task.Task3
{
    internal class Department
    {
        public string Name { get; set; }
        private int EmployeeLimit;
        private int SalaryLimit;
        private int employeeCount = 0;
        Employee[] employees = new Employee[10];

        public Department(string name)
        {
            name = Name;
        }
        public int GetEmployeeLimit()
        {
            return EmployeeLimit;
        }
        public void SetEmployeeLimit(int employeeLimit)
        {
            EmployeeLimit = employeeLimit;
        }
        public int GetSalaryLimit()
        {
            return SalaryLimit;
        }
        public void SetSalaryLimit(int salaryLimit)
        {
            if (SalaryLimit >= 250)
            {
                salaryLimit = SalaryLimit;
            }
            else
            {
                throw new Exception("Emek haqqi minimum 250 olmalidi");
            }
        }
        public void AddEmployee(Employee employee)
        {
            if (employeeCount < EmployeeLimit)
            {
                employees[employeeCount] = employee;
                employeeCount++;
                Console.WriteLine("Employee added successfully.");
            }
            else
            {
                Console.WriteLine("Employee limit reached. Cannot add more employees.");
            }
        }

    } 
}
