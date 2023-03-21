using CSharpBasics.Repository;
using System;
using CSharpBasics.Entities;
using CSharpBasics.Common;

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

            public static Employee copy(Employee copy)
            {
                var emp = new Employee();
                emp.EmployeeId = copy.EmployeeId;
                emp.EmployeePhone = copy.EmployeePhone;
                emp.EmployeeSalary = copy.EmployeeSalary;
                emp.EmployeeName = copy.EmployeeName;
                emp.EmployeeEmail = copy.EmployeeEmail;
                return emp;
            }

            public void DeleteEmployee(int id)
            {
                for (int i = 0; i < _employees.Length; i++)
                {
                    if ((_employees[i] != null) && (_employees[i].EmployeeId == id))
                    {
                        _employees[i] = null;//We dont have delete operator, so set to null
                        return;
                    }
                }
                Console.WriteLine("No Matching Record found to delete");
            }
            public void UpdateEmployee(Employee emp)
            {
                //Iterate thru the array...
                for (int i = 0; i < _employees.Length; i++)
                {
                    //Find the matching Emp based on Id.
                    if ((_employees[i] != null) && (_employees[i].EmployeeId == emp.EmployeeId))
                    {
                        _employees[i] = copy(emp);
                        return;//exit the function and no further iteration is required. 
                    }
                }
                Console.WriteLine("No record was found to update");
            }
            public EmployeeRepo(int size)
            {
                _employees = new Employee[size];
                _employees[0] = new Employee { EmployeeEmail = "test1@gmail.com", EmployeeId = 111, EmployeeName = "Phaniraj", EmployeePhone = 9945205684, EmployeeSalary = 56000 };
                _employees[1] = new Employee { EmployeeEmail = "test2@gmail.com", EmployeeId = 112, EmployeeName = "Ramesh", EmployeePhone = 9449184401, EmployeeSalary = 46000 };
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
                Employee[] array = new Employee[0];
                foreach (var emp in _employees)
                {
                    if(emp != null)
                    {
                        var temp = (Employee[])array.Clone();
                        if (temp.Length == 0)
                        {
                            array = new Employee[1];//Only for the first element...
                            array[0] = emp;
                        }
                        else
                        {
                            array = new Employee[temp.Length + 1];
                            Array.Copy(temp, array, temp.Length);
                            array[array.Length - 1] = emp;
                        }
                    }
                }
                return array;
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
                int choice = MyConsole.GetNumber(MENU);
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
                displayRecord(emp);   
            }
        }

        private static void displayRecord(Employee emp)
        {
            Console.WriteLine($"Here are the details: \nThe Name:{emp.EmployeeName}\nThe Email Address: {emp.EmployeeEmail}\nThe Contact No: {emp.EmployeePhone}\nThe Salary: {emp.EmployeeSalary}\nThe Employee ID: {emp.EmployeeId}");
        }

        private static void addingNewEmployee()
        {
            var emp = new Employee();
            emp.EmployeeId = MyConsole.GetNumber("Enter the Id");            
            emp.EmployeeName = MyConsole.GetString("Enter the Name of the Employee");
            emp.EmployeeEmail = MyConsole.GetString("Enter the Email Address of the Employee");
            emp.EmployeePhone = MyConsole.GetLong("Enter the Contact no of the Employee");
            emp.EmployeeSalary = MyConsole.GetNumber("Enter the Salary of the Employee");
            _repo.AddNewEmployee(emp);
            Console.WriteLine("Employee added successfully");
        }
    }
}
