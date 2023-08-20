using Java_Floral.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Java_Floral.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , ProductContext context)
        {
            _logger = logger;
            _context = context;

        }


        // GET: Products
        //public async Task<IActionResult> Index()
        //{
        //    var productContext = _context.Products.Include(p => p.PCategory);
        //    return View(await productContext.ToListAsync());
        //}
        // GET: products
        public async Task<IActionResult> Index(int currentPage = 1)
        {
            var list = await _context.Products.Include(p => p.PCategory).ToListAsync();
            ViewBag.totalPages = Math.Ceiling(list.Count() / 8.0); // 20/8  ==> 2.9 ==> 3  

            ViewBag.cPage = currentPage;
            //
            list = list.Skip((currentPage - 1) * 8).Take(8).ToList(); // ==>? 1-1 = 0*8 ==>
            return View(list);
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
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
