using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using program.Models.Context;
using program.Models.Entities;

namespace program.Repository.Com
{
    public class CategoryRepository : ICategoryRepository
    {
        MagazineContext context;
        public CategoryRepository(MagazineContext _companyContext)
        {
            context = _companyContext;
        }

        public List<Category> GetAllC()
        {
            return context.Categories.Include(c => c.posts).Include(c => c.users).ToList();
        }
        public Category GetByIdc(int id)
        {
            return context.Categories.Include(c => c.users).Include(c => c.posts).FirstOrDefault(c => c.CategoryId == id);
        }
        public void Create(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }
        public void Edit(int id, Category category)
        {
            Category CategoryToEdit = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (CategoryToEdit == null)
            {
                throw new ArgumentException($"Category with ID {id} not found.");
            }
            CategoryToEdit.CategoryName = category.CategoryName;
            CategoryToEdit.CategoryDate = category.CategoryDate;
            context.Categories.Update(CategoryToEdit);
            context.SaveChanges();
        }
        //public void Delete(int id)
        //{
        //    var companyToDelete = context.companies.FirstOrDefault(c => c.CompanyId == id);
        //    context.companies.Remove(companyToDelete);
        //    context.SaveChanges();
        //}

    }
}
