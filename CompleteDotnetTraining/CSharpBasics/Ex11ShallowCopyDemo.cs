using CSharpBasics.Entities;
using CSharpBasics.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex11ShallowCopyDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                EmployeeEmail = "testemail@gmail.com", EmployeeId= 1, EmployeeName="Test Name", EmployeePhone = 2343256, EmployeeSalary = 67000
            };

            Employee copy = EmployeeRepo.copy(emp);//Deep Copy
            //Employee copy = emp;//Shallow copy..
            Console.WriteLine("The HashCode of emp object is " + emp.GetHashCode());
            Console.WriteLine("The HashCode of copy object is " + copy.GetHashCode());
            Console.WriteLine($"{ copy.EmployeeName} and {emp.EmployeeName}");
            emp.EmployeeName = "Modified Name";
            Console.WriteLine($"{copy.EmployeeName} and {emp.EmployeeName}");


        }
    }
}
