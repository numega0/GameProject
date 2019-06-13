using System.Data.Entity;
using GameProject.Entity.Concrete;

namespace GameProject.Dal.Concrete.EntityFramework.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameImage> GameImages { get; set; }

        public DatabaseContext() : base("name=DatabaseContext")
        {
            Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseIfModelChanges<DatabaseContext>()); ;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.UserName).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Password).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Role).HasColumnType("nvarchar").HasMaxLength(2);

            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<Category>().Property(c => c.Description).HasColumnType("nvarchar").HasMaxLength(200);

            modelBuilder.Entity<Game>().Property(g => g.Name).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<Game>().Property(g => g.Description).HasColumnType("nvarchar").HasMaxLength(200);

        }
    }
}
