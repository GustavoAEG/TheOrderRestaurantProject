using Microsoft.EntityFrameworkCore;
using TheOrderRestaurantProject.Models;

namespace TheOrderRestaurantProject.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }


    }
}
