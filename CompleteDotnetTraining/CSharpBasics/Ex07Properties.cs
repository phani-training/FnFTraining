using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We have created a new namespace to avoid the naming conflict with the Employee class that is available in the previous Example..
namespace CSharpBasics.PropertiesExample
{
    class Employee
    {
        int _empId;
        string _empName;
        string _empAddress;
        int _empSalary;

        public int EmployeeId
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public string EmployeeName
        {
            get { return _empName; }
            set { _empName = value; }
        }

        public string EmpAddress
        {
            get { return _empAddress; }
            set { _empAddress = value; }
        }

        public int EmpSalary 
        {
            get { return _empSalary; }
            set { _empSalary = value; }
        }
    }
    internal class Ex07Properties
    {
        static void Main(string[] args)
        {
            Employee emp =new Employee();
            Console.WriteLine("Enter the EmpID");
            emp.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the EmpName");
            emp.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter the Employee Address");
            emp.EmpAddress= Console.ReadLine();

            Console.WriteLine("Enter the Employee Salary");
            emp.EmpSalary  = int.Parse(Console.ReadLine());

            Console.WriteLine("The details of the Employee is set!!!!");
            string message = $"The Name of the Employee is {emp.EmployeeName} from {emp.EmpAddress} and earns a Salary of {emp.EmpSalary:C}";
            Console.WriteLine(message);
        }
    }
}
