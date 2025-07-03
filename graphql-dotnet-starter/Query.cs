using graphql_dotnet_starter.Models;
using graphql_dotnet_starter.Service.Abstracts;

namespace graphql_dotnet_starter
{
    public class Query
    {
        private readonly IProductSearchService _productSearchService;

        public Query(IProductSearchService productSearchService, IFavoriteService favoriteService)
        {
            _productSearchService = productSearchService;
        }

        public async Task<List<Product>> GetProducts(string userId, string searchTerm)
        {
            var products = await _productSearchService.SearchProductsAsync(searchTerm);

            return products;
        }
    }
}
