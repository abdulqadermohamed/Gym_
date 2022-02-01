using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym_.Data;
using Gym_.Models;

namespace Gym_.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDBContext _context;

        public UsersController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.Where(x => x.TypeOfUser == (int)Enums.UserType.User)
                   .Select(x => new UsersViewModel
                   {
                       Id = x.Id,
                       Subscription = x.Subscriptions.Select(y => y.Subscription.Name).FirstOrDefault(),
                       UserName = x.UserName,
                       Phone = x.Phone,
                       Age = x.Age,
                       Address = x.Address,
                       Status = x.IsActive
                   }).ToListAsync();

            return View(users);
        }



        [HttpPost]
        public async Task<IActionResult> ChangeUserStatus(int id)
        {
            var foundUser =await _context.Users.FindAsync(id);

            foundUser.IsActive = !foundUser.IsActive;
            await _context.SaveChangesAsync();

            return Json(new { data = foundUser.IsActive });
        }
    }
}
