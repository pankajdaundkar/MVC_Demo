using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Products>
    products = new List<Products>
        ()
        {
        new Products{Id=1,Name="Pen",Price=10},
        new Products{Id=2,Name="Pencil",Price=13.78},
        new Products{Id=3,Name="Mouse",Price=190.37},
        new Products{Id=4,Name="Mobile",Price=1363.78},
        new Products{Id=5,Name="Laptop",Price=10000}
        };
            ViewData["list"] = products;
            return View();
        }


    }
}
