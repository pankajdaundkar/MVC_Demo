using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
namespace MVC_Demo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
        {
            List<Student> students = new List<Student>()
            {
                new Student {Id=1, Name="Pankaj",Percentage=78.90},
                new Student {Id=2, Name="Sagar",Percentage=77.87},
                new Student {Id=3, Name="Pratik",Percentage=87.65},
                new Student {Id=4, Name="Nilesh",Percentage=90.56},
                new Student {Id=5, Name="Girish",Percentage=95.56}
            };
            ViewData["list"]=students;
            return View();
        }
    }
}
