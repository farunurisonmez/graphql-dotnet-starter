using graphql_dotnet_starter.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

app.MapGraphQL();

app.Run();
