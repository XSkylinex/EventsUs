using System.Linq;
using System.Threading.Tasks;
using EventsUs.Data;
using EventsUs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventsUs.Areas.CalendarUser.Controllers
{
    [Area("CalendarUser")]
    public class FindFriendsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FindFriendsController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            return View(_context.ApplicationUser.ToList());
        }

    }
}
