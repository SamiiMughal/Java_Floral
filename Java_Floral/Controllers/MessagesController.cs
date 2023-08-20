﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Java_Floral.Models;
//using Microsoft.AspNetCore.Identity;

//namespace Java_Floral.Controllers
//{
//    public class MessagesController : Controller
//    {
//        private readonly ProductContext _context;
//        private readonly UserManager<IdentityUser> UserManager;
//        private readonly SignInManager<IdentityUser> SignInManager;

//        public MessagesController(ProductContext context, UserManager<IdentityUser> UserManager, SignInManager<IdentityUser> SignInManager)
//        {
//            _context = context;
//            this.UserManager = UserManager;
//            this.SignInManager = SignInManager;
//        }

//        // GET: Messages
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.Message.ToListAsync());
//        }

//        // GET: Messages/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var message = await _context.Message
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (message == null)
//            {
//                return NotFound();
//            }

//            return View(message);
//        }

//        // GET: Messages/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Messages/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(Message Msg)
//        {   


//          UserManager.FindByEmailAsync(SignIn.email);


//            if (ModelState.IsValid)
//            {
//                var mess = new Message()
//                {
//                    userid = email,
//                    message = Msg.message
//                };
//                _context.Add(mess);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }

//            return View(Msg);
//        }

//        // GET: Messages/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var message = await _context.Message.FindAsync(id);
//            if (message == null)
//            {
//                return NotFound();
//            }
//            return View(message);
//        }

//        // POST: Messages/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,userid,message")] Message message)
//        {
//            if (id != message.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(message);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!MessageExists(message.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(message);
//        }

//        // GET: Messages/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var message = await _context.Message
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (message == null)
//            {
//                return NotFound();
//            }

//            return View(message);
//        }

//        // POST: Messages/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var message = await _context.Message.FindAsync(id);
//            _context.Message.Remove(message);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool MessageExists(int id)
//        {
//            return _context.Message.Any(e => e.Id == id);
//        }
//    }
//}
