




using Lalit_Pant_Dot_Net_Assignment.Data;
using Lalit_Pant_Dot_Net_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lalit_Pant_Dot_Net_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Donor()
        {
            var donors = _context.Donors.ToList(); // Fetch all donors
            return View(donors);
        }



        public IActionResult BloodBank()
        {
            var BloodBanks = _context.BloodBanks.ToList();  // Fetch all blood banks
            return View(BloodBanks);
        }

    }
}







//using System.Diagnostics;
//using Lalit_Pant_Dot_Net_Assignment.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace Lalit_Pant_Dot_Net_Assignment.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;

//        public HomeController(ILogger<HomeController> logger)
//        {
//            _logger = logger;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
