using graphql_dotnet_starter.Models;

namespace graphql_dotnet_starter.Service.Abstracts
{
    public interface IProductSearchService
    {
        Task<List<Product>> SearchProductsAsync(string query);
    }
}
