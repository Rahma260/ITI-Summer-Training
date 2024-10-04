using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using program.Models.Context;
using program.Models.Entities;

namespace program.Repository.Pos
{
    public class PostRepository : IPostRepository
    {
        MagazineContext context;
        public PostRepository(MagazineContext _companyContext)
        {
            context = _companyContext;
        }
        public List<Post> GetAll()
        {
            return context.Posts.Include(p => p.PostUser).Include(p => p.PostCategory).OrderByDescending(p => p.PostDate).ToList();

        }
        public Post GetById(int id)
        {
            return context.Posts.Include(p => p.PostCategory).Include(p => p.PostUser).FirstOrDefault(u => u.PostId == id);
        }
        public void Create(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
        }
       
        public void Edit(int id, Post post)
        {
            Post postToUpdate = GetById(id);
            postToUpdate.PostTitle = post.PostTitle;
            postToUpdate.PostDate = post.PostDate;
            postToUpdate.UserId = post.UserId;
            postToUpdate.PostBody = post.PostBody;
            postToUpdate.PostImage = post.PostImage;
            postToUpdate.CategoryId = post.CategoryId;
            context.Posts.Update(postToUpdate);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var postToDelete = context.Posts.FirstOrDefault(p => p.PostId == id);
            context.Posts.Remove(postToDelete);
            context.SaveChanges();

        }
    }
}
