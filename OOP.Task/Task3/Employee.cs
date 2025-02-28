using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task.Task3
{
    //Employee Name və Surname dəyərləri yalnız hərflərdən ibarət olmalıdır və Böyük hərflə başlamalıdır ve minimum uzunlugu 3 olmalidir
    //Salary dəyəri 250-dən aşağı ola bilməz
    //AddEmployee metodu employees array-e employee obyekti əlavə etmək üçündür.Bu metod işə düşəndə əgər employeeLimit aşılırsa xəta mesajı çıxardın
    internal class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;
        private Department _department;

        public Employee(string Name , string Surname,double Salary,Department Department)
        {
            _surname = Surname;
            _department = Department;
            SetName(Name);
            SetSalary(Salary);
        }
        public string GetName()
        {
            return _name;
        }
        private void SetName(string name)
        {
            if (name.Length >= 3 && !name.Any(char.IsNumber) && !name.Any(char.IsDigit)&& char.IsUpper(name[0]))
            {
                _name = name;
            }
            else
            {
                throw new Exception("Ad duzgun deyil");
            }
        }
        public double GetSalary()
        {
            return _salary;
        }
        private void SetSalary(double salary)
        {
            if (salary >= 250)
            {
                _salary = salary;
            }
            else
            {
                throw new Exception("Emek haqqi 250-den asagi ola bilmez !");
            }
        }

    }
}

