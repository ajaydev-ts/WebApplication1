using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Employee cr = new Employee();
        public IActionResult Index()
        {
            return View();
        }

    }
}
