using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Employee
    {
        int _empId;
        string _empName;
        string _empAddress;
        int _empSalary;


        public Employee(int empId, string empName, string empAddress, int empSalary)
        {
            _empId = empId;
            _empName = empName;
            _empAddress = empAddress;
            _empSalary = empSalary;
        }

        public int GetId() { return _empId; }
        public string GetEmpName() { return _empName;}
        public string GetEmpAddress() { return _empAddress;}
        public int GetEmpSalary() { return _empSalary;}

    }
    internal class Ex06ClassesDemo
    {
        static void Main(string[] args)
        {
            var empObj = new Employee(123, "Phaniraj", "Bangalore", 56000);
            string message = $"The Name of the Employee is {empObj.GetEmpName()} from {empObj.GetEmpAddress()} and earns a Salary of {empObj.GetEmpSalary():C}";
            Console.WriteLine(message);
        }
    }
}
