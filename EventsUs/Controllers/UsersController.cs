using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsUs.Data;
using EventsUs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsUs.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)  //search users by username and user id
        {
            var user = from e in _context.Users
                       select e;
            if (!string.IsNullOrEmpty(searchString))
            {
                user = user.Where(e => e.UserName.Contains(searchString));
            }
          
            return View(user);
            
        }

        // GET: Users
        public IActionResult Index1(string searchString)
        {
            var user = from e in _context.Users
                       select e;
            return View(user);
            //return View(await _context.Event.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
            if (@user == null)
            {
                return NotFound();
            }

            return View(@user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,UserName,age")]
            User @user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(@user);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @user = await _context.Users.FindAsync(id);
            if (@user == null)
            {
                return NotFound();
            }

            return View(@user);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Email,UserName,age")]
            User @user)
        {
            if (!id.Equals(@user.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(@user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(@user);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @user = _context.Users
                .FirstOrDefault(m => m.Id.Equals(id));
            if (@user == null)
            {
                return NotFound();
            }

            return View(@user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @user = await _context.Users.FindAsync(id);
            _context.Users.Remove(@user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id.Equals(id));
        }
    }
}
