using MyFirstDesign.Models;
using Microsoft.EntityFrameworkCore;

namespace MyFirstDesign.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Require> requires { get; set; }
    }
}
