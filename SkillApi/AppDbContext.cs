using Microsoft.EntityFrameworkCore;
using SkillApi.Models;

namespace SkillApi
{
    public class AppDbContext : DbContext
    {
        public DbSet<Apple> Apples { get; set; }

        public AppDbContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=applesdb;",
                new MySqlServerVersion(new Version(8, 0, 33)));
        }
    }
}
