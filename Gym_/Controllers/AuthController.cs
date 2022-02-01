using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Gym_.Data;
using Gym_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gym_.Controllers
{
    public class AuthController : Controller
    {

        private readonly AppDBContext _db;
        public AuthController(AppDBContext appDbContext)
        {
            _db = appDbContext;

        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            var checkUser = _db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password && x.IsActive);
            if (checkUser == null)
            {
                return Unauthorized();
            }
            if (checkUser.TypeOfUser == (int)Enums.UserType.Admin)
            {
                return RedirectToAction("Index", "Users");
            }
            else //user
            {
                return RedirectToAction("Index", "Home", new { userId = checkUser.Id });
            }

        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new Data.User
                {
                    Address = model.Address,
                    Age = model.Age,
                    Password = model.Password,
                    Phone = model.Phone,
                    TypeOfUser = (int)Enums.UserType.User,
                    UserName = model.UserName,
                    IsActive = true
                };


                _db.Users.Add(user);
                int x = _db.SaveChanges();

                return RedirectToAction(nameof(Login));

            }
            return View();
        }





    }
}