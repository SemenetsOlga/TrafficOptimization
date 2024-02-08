using Microsoft.AspNetCore.Mvc;

namespace TrafficOptimization.Controllers
{
    public class TrafficController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
