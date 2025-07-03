using graphql_dotnet_starter.DataLoaders;
using graphql_dotnet_starter.Models;
using graphql_dotnet_starter.Service.Abstracts;
using graphql_dotnet_starter.Services.Concrete;
using graphql_dotnet_starter.Types;

namespace graphql_dotnet_starter.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IProductSearchService, ProductSearchService>();
            builder.Services.AddSingleton<IFavoriteService, FavoriteService>();
            builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<ProductType>()
                .AddDataLoader<FavoriteDataLoader>();
        }
    }
}
