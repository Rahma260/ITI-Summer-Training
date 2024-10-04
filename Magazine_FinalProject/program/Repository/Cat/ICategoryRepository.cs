using program.Models.Entities;

namespace program.Repository.Com
{
    public interface ICategoryRepository
    {
        public List<Category> GetAllC();
        public Category GetByIdc(int id);
        public void Create(Category category);
        public void Edit(int id, Category category);
       // public void Delete(int id);
    }
}
