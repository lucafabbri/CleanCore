using Clean.Examples.CounterWebApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace Clean.Examples.CounterWebApp.Infrastructure
{
    public class CounterDbContext : DbContext
    {
        public DbSet<Counter> Counters { get; set; }
        public CounterDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
