namespace graphql_dotnet_starter.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddGraphQLServer();
        }
    }
}
