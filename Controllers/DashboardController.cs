using Microsoft.AspNetCore.Mvc;

namespace task.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashIndex()
        {
            return View();
        }
    }
}
