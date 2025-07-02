using graphql_dotnet_starter.Service.Abstracts;
using graphql_dotnet_starter.Services.Concrete;

namespace graphql_dotnet_starter.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IProductSearchService, ProductSearchService>();
            builder.Services.AddSingleton<IFavoriteService, FavoriteService>();
            builder.Services.AddGraphQLServer().AddQueryType<Query>();
        }
    }
}
