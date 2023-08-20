using Java_Floral.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Java_Floral.Controllers
{
    public class OccasionsController : Controller
    {
        private readonly ProductContext _context;

        public OccasionsController(ProductContext context)
        {
            _context = context;
        }

        public IActionResult index(string value = "")
        {
            //var list = _context.Products.ToList();

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
            //return View(await _context.Products.ToListAsync());

        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.PCategory)
                .FirstOrDefaultAsync(m => m.id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }


        public IActionResult Combo(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Mothers_Day(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Fathers_Day(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Love_And_Romance(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }

        public IActionResult Baby_Breath(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Baby_is_here(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Get_Well_Soon(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Sympaty(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Thank_you(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Anniversary(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Eid_Flowers(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Wedding(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Birthday(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Valentine_day(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
        public IActionResult Flower_Arrangments(string value = "")
        {

            var list = _context.Products.Include(e => e.PCategory).ToList();


            if (value != "")
            {
                list = _context.Products.Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
        }
       
    }
}
