using Microsoft.EntityFrameworkCore;
using MVC_Mini_Project.Models;

namespace MVC_Mini_Project.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
