using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCcodeFirstCRUID.Data;
using MVCcodeFirstCRUID.Models;
using System.Diagnostics;

namespace MVCcodeFirstCRUID.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private readonly DbContextOptions<MyDbContext> _context;
        
        private readonly MVCcfDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MVCcfDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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