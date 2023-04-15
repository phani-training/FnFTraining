using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class FirstController : Controller
    {
        public string TestMe() => "Welcome to Mvc";

        public Employee ShowDetails()
        {
            var emp = new Employee
            {
                Salary = 1000,
                Email = "phanirajbn@gmail.com",
                Id = 1,
                Name = "Phaniraj"
            };
            return emp;//JSON format of Employee
        }
        //U need a View only for the presentation of the Model. If U want raw data to be presented U can just return the data
        public IActionResult ShowEmployee()
        {
            //create the instance of the data that U want to show...
            var emp = new Employee
            {
                 Salary = 1000, Email ="phanirajbn@gmail.com", Id = 1, Name ="Phaniraj"
            };
            return View(emp);
        }

        public IActionResult DoSomeThing()
        {
            return View();
        }
    }
}
//Create an Interface IEmployeeRepo and implement the interface with JSON serialization. 