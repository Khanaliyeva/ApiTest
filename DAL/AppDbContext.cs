using ApiIntro.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiIntro.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> opt) : base(opt) { }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Color> colors { get; set; }

    
    }
}
