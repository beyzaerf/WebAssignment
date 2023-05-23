using InspireMe.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace InspireMe.Infrastructure.Contexts
{
    public class ImageBoardDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImageBoardDbContext).Assembly);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=inspireme.database.windows.net;Database=inspireme-db;User Id=inspiremeadmin;Password=inspireme_123");
            }
        }
    }
}
