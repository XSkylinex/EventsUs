using System;
using System.Linq;
using System.Threading.Tasks;
using EventsUs.Data;
using EventsUs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventsUs.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AdminUsersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminUsersController(ApplicationDbContext db){
            _db = db;
        }

        
        public IActionResult Index(){
            
            return View(_db.ApplicationUser.ToList());
        }

        //get edit
        public async Task<IActionResult> Edit(string id){
            if (id == null || id.Trim().Length == 0){
                return NotFound();
            }

            var userFromDb = await _db.ApplicationUser.FindAsync(id);
            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }

        //post edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (string id, ApplicationUser applicationUser){
            if (id != applicationUser.Id)
            {
                return NotFound();

            }

            if (ModelState.IsValid)
            {
                ApplicationUser userFromDb = _db.ApplicationUser.Where(u=>u.Id==id).FirstOrDefault();
                userFromDb.Name = applicationUser.Name;
                userFromDb.PhoneNumber = applicationUser.PhoneNumber;

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(applicationUser);
            
        }


        //Get Delete
        
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }

            var userFromDb = await _db.ApplicationUser.FindAsync(id);
            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }

        //post edit
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(string id)
        {

                ApplicationUser userFromDb = _db.ApplicationUser.Where(u =>u.Id == id).FirstOrDefault();
                userFromDb.LockoutEnd = DateTime.Now.AddYears(1000);

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));


        }
        public IActionResult Graph()
        {

            return View(_db.ApplicationUser.ToList());
        }
        public JsonResult GraphJson()
        {
            var pl = from r in _db.ApplicationUser
                orderby r.Country
                group r by r.Country into grp
                select new { area = grp.Key, value = grp.Count() };

            return Json(pl.ToList());


        }

    }




}