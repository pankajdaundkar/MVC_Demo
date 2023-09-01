using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
namespace MVC_Demo.Controllers
{
    public class EMPController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EMP e)
        {
            return View();
        }
    }
}
