using Microsoft.AspNetCore.Mvc;

namespace MajesticAgency.Controllers
{
    public class GetstartedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
