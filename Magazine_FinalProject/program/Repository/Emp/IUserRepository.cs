using program.Models.Entities;

namespace program.Repository.Emp
{
    public interface IUserRepository
    {
        public List<User> GetAll();
        public User GetById(int id);
        public void Create(User user);
        public void Edit(int id, User user);
        public void Delete(int id);

    }
}
