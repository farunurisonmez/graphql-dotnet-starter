using graphql_dotnet_starter.Models;
using graphql_dotnet_starter.Service.Abstracts;

namespace graphql_dotnet_starter.Services.Concrete
{
    public class ProductSearchService : IProductSearchService
    {
        public Task<List<Product>> SearchProductsAsync(string query)
        {
            var all = new List<Product>
            {
                new() { Id = "1", Name = "iPhone 15" },
                new() { Id = "2", Name = "Galaxy S24" },
                new() { Id = "3", Name = "Pixel 8" }
            };

            return Task.FromResult(all.Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList());
        }
    }
}
