using Microsoft.EntityFrameworkCore;
using pms.api.Model;

namespace pms.api.Data
{
    public class PMSDbContext : DbContext
    {
        public PMSDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
    }
}
