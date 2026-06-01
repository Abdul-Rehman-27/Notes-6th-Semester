using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Today is Last day of classes";
            return View();
        }
    }
}