using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventsUs.Data;
using EventsUs.Models;

namespace EventsUs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GlobalEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GlobalEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/GlobalEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.GlobalEvent.ToListAsync());
        }

        // GET: Admin/GlobalEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var globalEvent = await _context.GlobalEvent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (globalEvent == null)
            {
                return NotFound();
            }

            return View(globalEvent);
        }

        // GET: Admin/GlobalEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/GlobalEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Name,Description,Location")] GlobalEvent globalEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(globalEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(globalEvent);
        }

        // GET: Admin/GlobalEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var globalEvent = await _context.GlobalEvent.FindAsync(id);
            if (globalEvent == null)
            {
                return NotFound();
            }
            return View(globalEvent);
        }

        // POST: Admin/GlobalEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Name,Description,Location")] GlobalEvent globalEvent)
        {
            if (id != globalEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(globalEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GlobalEventExists(globalEvent.Id))
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
            return View(globalEvent);
        }

        // GET: Admin/GlobalEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var globalEvent = await _context.GlobalEvent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (globalEvent == null)
            {
                return NotFound();
            }

            return View(globalEvent);
        }

        // POST: Admin/GlobalEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var globalEvent = await _context.GlobalEvent.FindAsync(id);
            _context.GlobalEvent.Remove(globalEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GlobalEventExists(int id)
        {
            return _context.GlobalEvent.Any(e => e.Id == id);
        }

        [HttpGet]
        public GlobalEvent[] getAllGlobalEvents()
        {
            var @globalEvent = _context.GlobalEvent;
            return @globalEvent.ToArray();
        }

    }
}
