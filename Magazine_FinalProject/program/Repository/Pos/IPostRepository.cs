using program.Models.Entities;

namespace program.Repository.Pos
{
    public interface IPostRepository
    {
        public List<Post> GetAll();
        public Post GetById(int id);
        public void Create(Post post);
        public void Edit(int id, Post post);
        public void Delete(int id);
    }
}
