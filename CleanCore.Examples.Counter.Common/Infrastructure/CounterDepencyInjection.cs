using CleanCore.Application.Services;
using CleanCore.Examples.CounterWebApp.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using CleanCore.Infrastructure.Data.Interceptors;

namespace CleanCore.Examples.CounterWebApp.Infrastructure
{
    /// <summary>
    /// The counter depency injection class
    /// </summary>
    public static class CounterDepencyInjection
    {
        /// <summary>
        /// Adds the counters using the specified services
        /// </summary>
        /// <param name="services">The services</param>
        /// <returns>The services</returns>
        public static IServiceCollection AddCounters(this IServiceCollection services, Assembly? serviceAssembly = null)
        {
            services.AddSingleton<IUserProvider, UserProvider>();
            services.AddSingleton<IOrganizationProvider<int>, OrganizationProvider>();

            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(serviceAssembly ?? Assembly.GetExecutingAssembly());
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
        /// <summary>
        /// Adds the counters using the specified services
        /// </summary>
        /// <param name="services">The services</param>
        /// <returns>The services</returns>
        public static IServiceCollection AddElasticCounters(this IServiceCollection services, Assembly? serviceAssembly = null)
        {
            services.AddSingleton<IUserProvider, UserProvider>();
            services.AddSingleton<IOrganizationProvider<int>, OrganizationProvider>();

            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(serviceAssembly ?? Assembly.GetExecutingAssembly());
            });

            services.AddSingleton(TimeProvider.System);
            return services;
        }
    }
}
