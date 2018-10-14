using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EventsUs.Data;
using EventsUs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Data;
using Microsoft.ML.Legacy.Models;
using Microsoft.ML.Legacy.Trainers;
using Microsoft.ML.Legacy.Transforms;

namespace EventsUs.Areas.CalendarUser.Controllers
{
    [Area("CalendarUser")]
    [Authorize(Roles = "Admin,CalendarUser")]
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Events
        public async Task<IActionResult> Index(string searchString1, string searchString2, string searchString3, string gBy, string jBy)
        {
   
            if (gBy == "Location")
            {
                var EventByID =
                   from u in _context.Event
                   where u.PublicPrivate.Equals(true)
                   group u by u.Location into g
                  
                   select new { Location = g.Key, count = g.Count(), g.First().Name };
                var group = new List<Event>();
                foreach (var t in EventByID)
                {
                    group.Add(new Event()
                    {
                        PublicPrivate = true,
                        Name = "Event Counter:" + t.count.ToString(),
                        Location = t.Location
                    });
                }

                return View(group);
            }
            if (jBy == "Admin")
            {
                var join =
                from u in _context.Event
                where u.PublicPrivate.Equals(true)
                join p in _context.Users on u.EventAdminId equals p.UserName

                select new { u.Name, u.Location, p.UserName,u.Date,u.Description };

                var UserList = new List<Event>();
                foreach (var t in join)
                {
                    UserList.Add(new Event()
                    {
                        PublicPrivate = true,
                        Name = t.Name,
                        Location = t.Location,
                        Date = t.Date,
                        Description = t.Description

                    });
                }
                return View(UserList);
            }
            if (jBy == "Place")
            {
                var join =
                from u in _context.Event
                where u.PublicPrivate.Equals(true)
                join p in _context.ApplicationUser on u.Location equals p.Country

                select new { u.Name, u.Location, p.UserName, u.Date, u.Description };

                var UserList = new List<Event>();
                foreach (var t in join)
                {
                    UserList.Add(new Event()
                    {
                        PublicPrivate = true,
                        Name = t.Name,
                        Location = t.Location,
                        Date = t.Date,
                        Description = t.Description

                    });
                }
                return View(UserList);
            }
            var events = from e in _context.Event
                            select e;
            if(!string.IsNullOrEmpty(searchString1))
            {
                events = events.Where(e => e.Name.Contains(searchString1));
            }
            if (!string.IsNullOrEmpty(searchString2))
            {
                events = events.Where(e => e.Location.Contains(searchString2));
            }
            if (!string.IsNullOrEmpty(searchString3))
            {
                events = events.Where(e => e.Description.Contains(searchString3));
            }
            return View(events);
            //return View(await _context.Event.ToListAsync());
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
     
            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            if (@event.Predictpepole >= 0 && @event.Realcome==0)
            {
                var pipeline = new LearningPipeline();

                pipeline.Add(new TextLoader("Numberofcopartner.csv").CreateFrom<Numberofcopartner>(useHeader: true, separator: ','));
                pipeline.Add(new ColumnConcatenator("Features", "Sayyes"));
                pipeline.Add(new GeneralizedAdditiveModelRegressor());
                var modela = pipeline.Train<Numberofcopartner, NumberofcopartnerPrediction>();
                var testData = new TextLoader("Numberofcopartner.csv").CreateFrom<Numberofcopartner>(useHeader: true, separator: ',');
                var evaluator = new RegressionEvaluator();
                var metrics = evaluator.Evaluate(modela, testData);
                var prediction = modela.Predict(new Numberofcopartner { Sayyes = @event.Predictpepole });
                @event.MLPredictpepole = (int)prediction.RealCome;
            }
            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Name,Description,Location,YoutubeId,PublicPrivate,Predictpepole,Realcome")]
            Event @event)
        {
            if (ModelState.IsValid)
            {
 
                _context.Add(@event);
                @event.EventAdminId = HttpContext.User.Identity.Name;
                @event.Realcome = 0;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            @event.EventAdminId = HttpContext.User.Identity.Name;
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Name,Description,Location,YoutubeId,PublicPrivate,Predictpepole,Realcome")]
            Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    @event.EventAdminId = HttpContext.User.Identity.Name;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
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
            

            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Event.FindAsync(id);
            _context.Event.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }


        [HttpGet]
        public ViewResult getAllEventByDate(int day, int month, int year, string username)
        {
            var @event = _context.Event.Where(e => (e.Date.Day == day && e.Date.Month == month && e.Date.Year == year) && (e.PublicPrivate == true||e.EventAdminId.Equals(username)));
            return View(@event.ToList());
        }

        [HttpGet]
        public ViewResult getAllEventDetails(int day, int month, int year,string username){
            var @event = _context.Event.Where(e => e.Date.Day == day && e.Date.Month == month && e.Date.Year == year&& (e.EventAdminId.Equals(username) || e.PublicPrivate == true)).Take(4);
            return View(@event.ToList());

        }

        //events graph
        public IActionResult Graph()
        {

            return View(_context.Event.ToList());
        }
        public JsonResult GraphJson()
        {
            var pl = from r in _context.Event
                     orderby r.Date.Month
                     where r.PublicPrivate == true
                     group r by r.Date.Month into grp
                     select new { area = grp.Key, value = grp.Count() };

            return Json(pl.ToList());


        }
    }
}
/// error= responseURL: "https://localhost:44351/CalendarUser/Events/GraphJson"
