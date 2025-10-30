using Microsoft.AspNetCore.Mvc;

namespace MajesticAgency.Controllers
{
    public class AboutusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
