using CleanCore.Examples.CounterWebApp.Domain;
using CleanCore.Examples.CounterWebApp.Infrastructure;
using CleanCore.Web.Endpoints;
using CleanCore.Web;
using CleanCore.Examples.CounterWebApp.DTO;
using CleanCore.Examples.CounterElasticWebApp.Application.Handlers;

var app = CleanApplication.Create(args,
    servicesBuilder: (services, configuration) => services.AddElasticCounters(typeof(CreateCounterHandler).Assembly));
app
    .MapEntity<string, ElasticCounter, ElasticCounterDto>(versions: [1, 2])
            .Find<string, ElasticCounter, ElasticCounterDto>(version: 1)
            .Create<string, ElasticCounter, ElasticCounterDto>(version: 1)
            .Modify<string, ElasticCounter, ElasticCounterDto>(version: 1)
            .Upsert<string, ElasticCounter, ElasticCounterDto>(version: 1)
            .UpsertMany<string, ElasticCounter, ElasticCounterDto>(version: 1)
            .Delete<string, ElasticCounter, ElasticCounterDto>(version: 1)
            .DeleteMany<string, ElasticCounter, ElasticCounterDto>(version: 1);

app.Run();