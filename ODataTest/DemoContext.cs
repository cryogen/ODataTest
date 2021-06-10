using Microsoft.EntityFrameworkCore;

namespace ODataTest
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Parent> Parent { get; set; }
    }
}