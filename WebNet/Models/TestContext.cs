using Microsoft.EntityFrameworkCore;

namespace WebNet.Models
{
    public class TestContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
