using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sashiel_ST10028058_CLDV6212_POE.Models;

namespace Sashiel_ST10028058_CLDV6212_POE.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FileModel> Files { get; set; }
        public DbSet<User> User { get; set; }
    }
}
