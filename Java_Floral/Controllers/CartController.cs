using Microsoft.AspNetCore.Mvc;

namespace Java_Floral.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
