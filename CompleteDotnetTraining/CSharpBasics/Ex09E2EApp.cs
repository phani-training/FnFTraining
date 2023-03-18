using CSharpBasics.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasics.Entities;
using CSharpBasics.Repository;
namespace CSharpBasics
{
    namespace Entities
    {
        class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public string EmployeeEmail { get; set; }
            public long EmployeePhone { get; set; }
            public int EmployeeSalary { get; set; }
        }

    }

    namespace Repository
    {

        class EmployeeRepo
        {
            private Employee[] _employees;

            private Employee copy(Employee copy)
            {
                var emp = new Employee();
                emp.EmployeeId = copy.EmployeeId;
                emp.EmployeePhone = copy.EmployeePhone;
                emp.EmployeeSalary = copy.EmployeeSalary;
                emp.EmployeeName = copy.EmployeeName;
                emp.EmployeeEmail = copy.EmployeeEmail;
                return emp;
            }
            public EmployeeRepo(int size)
            {
                _employees = new Employee[size];
            }

            public EmployeeRepo() : this(0)
            {

            }
            public void AddNewEmployee(Entities.Employee emp)
            {
                //Iterate thro the array
                for (int i = 0; i < _employees.Length; i++)
                {
                    //Find the first occurance of null object in the array
                    if (_employees[i] == null)
                    {
                        //Fill the data into the indexed location.
                        _employees[i] = copy(emp);
                        return;//exit the Function
                    }
                }

                Console.WriteLine("No more employees could be added");                
                //If no space is available, will display message.
            }

            public Employee[] GetAllEmployees()
            {
                return _employees;
            }
        }
    }
    internal class Ex09E2EApp
    {
        const string MENU = "--------------------------------------------EMPLOYEE MONITORING SYSTEM-------------------\r\nTO ADD NEW EMPLOYEE-------------->PRESS 1\r\nTO DISPLAY ALL EMPLOYEES--------->PRESS 2\r\nTO UPDATE EMPLOYEE--------------->PRESS 3\r\nTO DELETE AN EMPLOYEE------------>PRESS 4\r\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT OF THE APPLICATION\r\n-----------------------------------------------------------------------------------------";
        static EmployeeRepo _repo = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of Employees of this Organization");
            int size = int.Parse(Console.ReadLine());

            _repo = new EmployeeRepo(size);
            bool processing = true;
            do
            {
                Console.WriteLine(MENU);
                int choice = int.Parse(Console.ReadLine());
                processing = processMenu(choice);
            } while (processing);
        }

        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingNewEmployee();
                    return true;
                case 2:
                    displayAllEmployees();
                    return true;
                case 3:
                case 4:
                    return true;
                default:
                    return false;
            }
        }

        private static void displayAllEmployees()
        {
            Employee[] records = _repo.GetAllEmployees();
            foreach(var emp in records)
            {
                if(emp != null)
                {
                    displayRecord(emp);
                }
            }
        }

        private static void displayRecord(Employee emp)
        {
            Console.WriteLine($"Here are the details: \nThe Name:{emp.EmployeeName}\nThe Email Address: {emp.EmployeeEmail}\nThe Contact No: {emp.EmployeePhone}\nThe Salary: {emp.EmployeeSalary}\nThe Employee ID: {emp.EmployeeId}");
        }

        private static void addingNewEmployee()
        {
            var emp = new Employee();
            Console.WriteLine("Enter the Id");
            emp.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name of the Employee");
            emp.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter the Email Address of the Employee");
            emp.EmployeeEmail = Console.ReadLine();

            Console.WriteLine("Enter the Contact no of the Employee");
            emp.EmployeePhone = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Salary of the Employee");
            emp.EmployeeSalary = int.Parse(Console.ReadLine());
            _repo.AddNewEmployee(emp);
            Console.WriteLine("Employee added successfully");
        }
    }
}
