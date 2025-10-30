using Core.Entities.ViewModel;
using Core.Interface;
using MajesticAgency.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MajesticAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;
        private readonly ISubService _subService;
        private readonly IOrder _order;
        private readonly IEmail _email;

        private readonly IConfiguration _configuration;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IService service, ISubService subService, IOrder order, IConfiguration configuration, IEmail email)
        {
            _logger = logger;
            _service = service;
            _subService = subService;
            _order = order;
            _configuration = configuration;
            _email = email;
        }

        public async Task<IActionResult> Index()
        {
            ViewModels viewModels = new ViewModels();
            viewModels.Services = await _service.GetServices();
            return View(viewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}