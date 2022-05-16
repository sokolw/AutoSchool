using Microsoft.AspNetCore.Mvc;

namespace AutoSchool.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
