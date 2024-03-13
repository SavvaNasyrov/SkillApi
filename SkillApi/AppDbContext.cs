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
    }
}
