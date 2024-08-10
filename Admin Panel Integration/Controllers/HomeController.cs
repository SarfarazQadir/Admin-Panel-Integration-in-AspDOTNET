using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Integration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
