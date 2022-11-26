using Microsoft.AspNetCore.Mvc;

namespace WorldcupWeb.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Match(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
