using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using program.Models.Context;
using program.Models.Entities;
using program.Repository.Com;
using program.Repository.Emp;
using System.Data;

namespace program.Controllers.EntitiesController
{
    public class CategoryController : Controller
    {
        ICategoryRepository cat;
        MagazineContext context;
        public CategoryController(ICategoryRepository category, MagazineContext context)
        {
            cat = category;
            this.context = context;

        }
        [HttpGet]
        public IActionResult GetAllC()
        {
            var allcategories = cat.GetAllC();
            return View("GetAllC", allcategories);
        }
        [HttpGet]
        public IActionResult GetByIdc(int id)
        {
            var category = cat.GetByIdc(id);
            return View(category);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {

            try
            {
                if (ModelState.IsValid == true)
                {
                   cat.Create(category);
                    return RedirectToAction("GetAllC");

                }
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(category); // to display the validation

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = context.Categories.Include(c => c.users).Include(c => c.users).FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound(); 
            }

            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(int id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            cat.Edit(id, category);
            return RedirectToAction("GetAllC", new { id = category.CategoryId });
        }

    }
}
