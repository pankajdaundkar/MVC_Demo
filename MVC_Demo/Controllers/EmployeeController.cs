using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
namespace MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {Id=1, Name="Pankaj",Salary=20000},
                new Employee {Id=2, Name="Sagar",Salary=40000},
                new Employee {Id=3, Name="Pratik",Salary=50000},
                new Employee {Id=4, Name="Nilesh",Salary=45000},
                new Employee {Id=5, Name="Girish",Salary=35000}
            };
            ViewData["list"] = employees;
            return View();
        }
    }
}
