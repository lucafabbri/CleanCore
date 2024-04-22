using Clean.Examples.CounterWebApp.Infrastructure.Services;
using Clean.Infrastructure.Data.Interceptors;
using Clean.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;

namespace Clean.Examples.CounterWebApp.Infrastructure
{
    public static class CounterDepencyInjection
    {
        public static IServiceCollection AddCounters(this IServiceCollection services)
        {
            services.AddSingleton<IUserProvider, UserProvider>();
            services.AddSingleton<IOrganizationProvider<int>, OrganizationProvider>();

            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddScoped<ISaveChangesInterceptor, BaseEntitySaveChangesInterceptor>();
            services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

            services.AddDbContext<CounterDbContext>((sp, options) =>
            {
                options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
                options.UseInMemoryDatabase("counters");
            });

            services.AddSingleton(TimeProvider.System);
            return services;
        }
    }
}
