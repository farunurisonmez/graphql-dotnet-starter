using graphql_dotnet_starter.Models;
using graphql_dotnet_starter.Service.Abstracts;

namespace graphql_dotnet_starter
{
    public class Query
    {
        private readonly IProductSearchService _productSearchService;
        private readonly IFavoriteService _favoriteService;

        public Query(IProductSearchService productSearchService, IFavoriteService favoriteService)
        {
            _productSearchService = productSearchService;
            _favoriteService = favoriteService;
        }

        public async Task<List<Product>> GetProducts(string userId, string searchTerm)
        {
            var products = await _productSearchService.SearchProductsAsync(searchTerm);
            var favorites = await _favoriteService.GetFavoriteProductIdsAsync(userId);

            foreach (var product in products)
            {
                product.IsFavorite = favorites.Contains(product.Id);
            }

            return products;
        }
    }
}
