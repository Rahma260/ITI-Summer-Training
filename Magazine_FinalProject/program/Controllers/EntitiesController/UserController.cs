using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using program.Models.Context;
using program.Models.Entities;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Numerics;
using program.Repository.Emp;

namespace program.Controllers.EntitiesController
{
    public class UserController : Controller
    {
        IUserRepository user;
        MagazineContext context;
        public UserController(IUserRepository _user, MagazineContext context)
        {
            user = _user;
            this.context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var allusers = user.GetAll();
            return View("GetAll", allusers);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var users = user.GetById(id);
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = context.Categories.ToList(); // Ensure this is populated
            ViewData["ListOfUsers"] = context.Users.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user1)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    user.Create(user1);
                    return RedirectToAction("GetAll");

                }
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return RedirectToAction("Create");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            User use = context.Users.Include(u => u.category).FirstOrDefault(u => u.UserId == id);
            ViewBag.Category = context.Categories.ToList();
            return View(use);
        }

        [HttpPost]
        public IActionResult Edit(int id, User user1)
        {
            user.Edit(id, user1);

            return RedirectToAction("GetAll", new { id = user1.UserId });
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            user.Delete(id);
            return RedirectToAction("GetAll");
        }
    }

}

