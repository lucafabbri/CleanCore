using Clean.Examples.CounterWebApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace Clean.Examples.CounterWebApp.Infrastructure
{
    /// <summary>
    /// The counter db context class
    /// </summary>
    /// <seealso cref="DbContext"/>
    public class CounterDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the value of the counters
        /// </summary>
        public DbSet<Counter> Counters { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterDbContext"/> class
        /// </summary>
        /// <param name="options">The options</param>
        public CounterDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
