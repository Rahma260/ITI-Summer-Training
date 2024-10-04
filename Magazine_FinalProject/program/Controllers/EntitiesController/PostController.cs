using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using program.Models.Context;
using program.Models.Entities;
using program.Repository.Pos;

namespace program.Controllers.EntitiesController
{
    public class PostController : Controller
    {
        IPostRepository pos;
        MagazineContext context;
        public PostController(IPostRepository _post, MagazineContext context)
        {
            pos = _post;
            this.context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var allposts = pos.GetAll();
            return View("GetAll", allposts);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var posts = pos.GetById(id);
            return View(posts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.User = context.Users.ToList();
            ViewBag.Category = context.Categories.ToList();// Ensure this is populated
            ViewData["ListOfPosts"] = context.Posts.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post post1)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    pos.Create(post1);
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
            ViewBag.User = context.Users.ToList();
            ViewBag.Category = context.Categories.ToList();

            Post post = pos.GetById(id);

            
            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(int id, Post post1)
        {
            pos.Edit(id, post1);
            return RedirectToAction("GetAll", new { id = post1.PostId });
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            pos.Delete(id);
            return RedirectToAction("GetAll");
        }
    }
}

