using Loplait.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Loplait.Controllers
{
    public class InfoCenterController : Controller
    {
        private readonly ILogger<InfoCenterController> _logger;

        public InfoCenterController(ILogger<InfoCenterController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TourMap()
        {
            return View();
        }

        public IActionResult KoreaIs()
        {
            return View();
        }

        public IActionResult Promotions()
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
