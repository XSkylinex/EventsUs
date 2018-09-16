using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventsUs.Data;
using EventsUs.Models;

namespace EventsUs.Controllers
{
    public class FindFriendsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FindFriendsController(ApplicationDbContext context)
        {
            _context = context;

        }
       

        // GET: FindFriends
        public async Task<IActionResult> Index()
        {
            return View(await _context.FindFriends.ToListAsync());
        }

        // GET: FindFriends/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var findFriends = await _context.FindFriends
                .FirstOrDefaultAsync(m => m.ID == id);
            if (findFriends == null)
            {
                return NotFound();
            }

            return View(findFriends);
        }

        // GET: FindFriends/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FindFriends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID")] FindFriends findFriends)
        {
            if (ModelState.IsValid)
            {
                _context.Add(findFriends);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(findFriends);
        }

        // GET: FindFriends/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var findFriends = await _context.FindFriends.FindAsync(id);
            if (findFriends == null)
            {
                return NotFound();
            }
            return View(findFriends);
        }

        // POST: FindFriends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID")] FindFriends findFriends)
        {
            if (id != findFriends.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(findFriends);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FindFriendsExists(findFriends.ID))
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
            return View(findFriends);
        }

        // GET: FindFriends/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var findFriends = await _context.FindFriends
                .FirstOrDefaultAsync(m => m.ID == id);
            if (findFriends == null)
            {
                return NotFound();
            }

            return View(findFriends);
        }

        // POST: FindFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var findFriends = await _context.FindFriends.FindAsync(id);
            _context.FindFriends.Remove(findFriends);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FindFriendsExists(string id)
        {
            return _context.FindFriends.Any(e => e.ID == id);
        }
    }

  
}
