using Microsoft.EntityFrameworkCore;
using program.Models.Entities;

namespace program.Models.Context
{
    public class MagazineContext : DbContext
    {
        public MagazineContext() : base() { }
        public MagazineContext(DbContextOptions<MagazineContext> options) : base(options)
        {

        }

        
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.PostUser)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Enable cascade delete
        }
    }
}
