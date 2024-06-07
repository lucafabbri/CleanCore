using Asp.Versioning;
using CleanCore.Examples.CounterWebApp.Domain;
using CleanCore.Examples.CounterWebApp.Infrastructure;
using CleanCore.Web.Endpoints;
using CleanCore.Web;

var app = CleanApplication.Create(args, 
    services: (services) => services.AddCounters(), 
    apiVersioning: (options) =>
                        options.Policies.Sunset(1)
                                        .Effective(DateTimeOffset.Now.AddDays(60)));
app
    .MapEntity<Counter>(versions: [1, 2])
    .All<Counter>(version: 1)
    .All<Counter>(version: 2);

app.Run();