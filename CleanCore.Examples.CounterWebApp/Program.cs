using Asp.Versioning;
using CleanCore.Examples.CounterWebApp.Domain;
using CleanCore.Examples.CounterWebApp.Infrastructure;
using CleanCore.Web.Endpoints;
using CleanCore.Web;
using CleanCore.Examples.CounterWebApp.DTO;
using CleanCore.Examples.CounterWebApp.Application.Handlers;

var app = CleanApplication.Create(args, 
    services: (services) => services.AddCounters(typeof(CreateCounterHandler).Assembly), 
    apiVersioning: (options) =>
                        options.Policies.Sunset(1)
                                        .Effective(DateTimeOffset.Now.AddDays(60)));
app
    .MapEntity<int, Counter, CounterDto>(versions: [1, 2])
    .All<int, Counter, CounterDto>(version: 1)
    .All<int, Counter, CounterDto>(version: 2);

app.Run();