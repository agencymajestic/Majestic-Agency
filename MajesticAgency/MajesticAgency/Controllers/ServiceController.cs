using Core.Entities;
using Core.Entities.ViewModel;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MajesticAgency.Controllers
{
    public class ServiceController : Controller
    {
		private readonly IService _service;

		public ServiceController(IService service)
		{
			_service = service;
		}
		public async Task<IActionResult> Index()
        {
			ViewModels viewModels = new ViewModels();
			viewModels.Services = await _service.GetServices();
			return View(viewModels);
		}
		public async Task<IActionResult> Details(int id)
        {
			var service = await _service.GetService(id);
			return View(service);
		}
	}
}
