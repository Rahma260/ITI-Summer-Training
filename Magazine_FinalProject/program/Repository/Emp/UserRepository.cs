using Microsoft.EntityFrameworkCore;
using program.Models.Context;
using program.Models.Entities;
using System.Runtime.Intrinsics.X86;

namespace program.Repository.Emp
{
    public class UserRepository : IUserRepository
    {
        MagazineContext context;
        public UserRepository(MagazineContext _companyContext)
        {
            context = _companyContext;
        }
        public List<User> GetAll()
        {
            return context.Users.Include(u => u.Posts).ToList();

        }
        public User GetById(int id)
        {
            return context.Users.Include(u => u.category).FirstOrDefault(u => u.UserId == id);
        }
        public void Create(User user)
        {
            User user1 = new User();
            user1.UserName = user.UserName;
            user1.UserAge = user.UserAge;
            user1.UserGender = user.UserGender;
            user1.UserAddresss = user.UserAddresss;
            user1.UserSalary = user.UserSalary;
            user1.UserDate = user.UserDate;
            user1.UserImage = user.UserImage;
            user1.CategoryId = user.CategoryId;
            context.Users.Add(user1);
            context.SaveChanges();
        }
        //public void Create(User user)
        //{
        //    context.Users.Add(user); // Directly add the passed user
        //    context.SaveChanges();
        //}

        public void Edit(int id, User user)
        {
            User userToUpdate = GetById(id);
            userToUpdate.UserName = user.UserName;
            userToUpdate.UserAge = user.UserAge;
            userToUpdate.UserGender = user.UserGender;
            userToUpdate.UserAddresss = user.UserAddresss;
            userToUpdate.UserSalary = user.UserSalary;
            userToUpdate.UserDate = user.UserDate;
            userToUpdate.UserImage = user.UserImage;
            userToUpdate.CategoryId = user.CategoryId;
            context.Users.Update(userToUpdate);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var userToDelete = context.Users.Include(p => p.Posts).FirstOrDefault(u => u.UserId == id);
            if (userToDelete != null)
            {
               // context.Posts.RemoveRange(userToDelete.Posts);
                context.Users.Remove(userToDelete);
                context.SaveChanges();
            }
        }
    }
}