using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.X509Certificates;
//Purpose: Example to show on how to share the data b/w the controller and View.
/*
There are 5 ways to traverse the data from controller to the View:
Model : There can be only one data type to be used in a model for a given View. 
ViewBag : Like a Dynamic object that can store any of data, internally its a Dictionary
ViewData: Dictionary that has boxed data. Data is stored as Object. 
TempData: Stores the data for a temporory period. ViewBag and ViewData are scoped to the Action method in which they are created. 
Session: Based on HTTP session, it will remain for a long period untill the App User closes the browser. 
 */

/*
 * There are 3 ways to send the data from the View to the Controller
 * Model
 * FormsCollection object
 * Parameters of the method
 */
namespace SampleMvcApp.Controllers
{
    public class CalcController : Controller
    {

        private void setValues()
        {
            var items = new List<SelectListItem> {
             new SelectListItem{ Text = "Add"},
             new SelectListItem{ Text = "Subtract"},
             new SelectListItem{ Text = "Multiply"},
             new SelectListItem{ Text = "Divide"},
            };
            //ViewBag object is availabe in the Controller class. 
            ViewBag.dpList = items;
        }
        public IActionResult Index()
        {
            setValues();
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection collection)
        {
            setValues();
            var firstValue = double.Parse(collection["txtNum1"]);
            var secondValue = double.Parse(collection["txtNum2"]);
            var operand = collection["operands"];
            var result = 0.0;
            switch (operand)
            {
                case "Add": result = firstValue + secondValue; break;
                case "Subtract": result = firstValue - secondValue; break;
                case "Multiply": result = firstValue * secondValue; break;
                case "Divide": result = firstValue / secondValue; break;
                default:
                    break;
            }
            ViewData["Result"] = result;
            return View();
        }

        public IActionResult DisplayResult(string txtNum1, string txtNum2, string operands)
        {
            setValues();
            var firstValue = double.Parse(txtNum1);
            var secondValue = double.Parse(txtNum2);
            var result = 0.0;
            switch (operands)
            {
                case "Add": result = firstValue + secondValue; break;
                case "Subtract": result = firstValue - secondValue; break;
                case "Multiply": result = firstValue * secondValue; break;
                case "Divide": result = firstValue / secondValue; break;
                default:
                    break;
            }
            ViewData["Result"] = result;
            return View("Index");
        }
    }
}
