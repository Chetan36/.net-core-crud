using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class WebApplication1Context: DbContext
    {
        public DbSet<User> Users { get; set; }

        public WebApplication1Context(DbContextOptions<WebApplication1Context> options): base(options)
        {

        }
        
    }
}