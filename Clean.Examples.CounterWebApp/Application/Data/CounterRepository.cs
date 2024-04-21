using Clean.Application.Persistence;
using Clean.Examples.CounterWebApp.Domain;
using Clean.Examples.CounterWebApp.Infrastructure;
using Clean.Infrastructure.Persistence;

namespace Clean.Examples.CounterWebApp.Application.Data
{
    public class CounterRepository : BaseEntityRepository<int, Counter, CounterDto, CounterDbContext>, IEntityRepository<int, Counter, CounterDto>
    {
        public CounterRepository(CounterDbContext context) : base(context)
        {
        }
    }
}
