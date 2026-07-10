using cruddotnet9.Data;
using cruddotnet9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cruddotnet9.Controllers
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
                var students = _context.Students.ToList();
                return View(students);
            }
         public IActionResult Privacy()
        {
            return View();
        }
       public IActionResult login()
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
