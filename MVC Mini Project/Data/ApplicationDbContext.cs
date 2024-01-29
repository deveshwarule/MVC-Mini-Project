using Microsoft.EntityFrameworkCore;

namespace MVC_Mini_Project.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
    }
}
