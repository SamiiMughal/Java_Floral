using Java_Floral.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Java_Floral.Areas.Admin.Controllers
{
    [Area("Security")]
    public class AccountsController : Controller
    {
        private readonly ProductContext _context;
        private readonly UserManager<IdentityUser> UserManager;
        private readonly SignInManager<IdentityUser> SignInManager;

        public AccountsController(ProductContext context , UserManager<IdentityUser> UserManager, SignInManager<IdentityUser> SignInManager)
        {
            this.UserManager = UserManager;
            this.SignInManager = SignInManager;
            _context = context;

        }

        //public async Task<IActionResult> myaccount()
        //{
        //    var productContext = _context.Products.Include(p => p.PCategory);
        //    return View(await productContext.ToListAsync());

        //}
        //[HttpPost]
        //public IActionResult myaccount(string textBox, string l = "")
        //{
        //    //var pro = _context.Products.ToList();

        //    var pro = _context.Products.Include(e => e.PCategory).ToList();

        //    if (textBox != null)
        //    {
        //        pro = _context.Products.Where(x => x.Ptitle.Contains(textBox)).ToList();
        //    }

        //    return View(pro);
        //}

        public IActionResult myaccount(string value = "")
        {
            //var list = _context.Products.ToList();
            ViewBag.category = new SelectList(_context.Categories.ToList(),"id","Name");

            var list = _context.Products.Include(e => e.PCategory).Where(e=>e.PCategory.id == 2).ToList();


            if (value != "")
            {
                list = _context.Products.Include(x=>x.PCategory).Where(x => x.PCategory.Name.Contains(value)).ToList();

            }
            return View(list);
            //return View(await _context.Products.ToListAsync());

        }

        public async Task<IActionResult> Signup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signup(SignupModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new IdentityUser
                {
                    Email = model.Email,
                    UserName = model.Email
                };
                var result = await UserManager.CreateAsync(data, model.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(data, isPersistent: false);
                    return RedirectToAction("index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }



        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



        public IActionResult Signin(string ReturnUrl)
        {
            if (!string.IsNullOrEmpty(ReturnUrl))
            {
                return RedirectToAction("Signup", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signin(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password,
                    model.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credentials" + "");
                }
            }
            return View(model);
        }


    }
}
