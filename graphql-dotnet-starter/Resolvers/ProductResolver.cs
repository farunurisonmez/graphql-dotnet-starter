using graphql_dotnet_starter.DataLoaders;
using graphql_dotnet_starter.Models;
using HotChocolate.Resolvers;

namespace graphql_dotnet_starter.Resolvers
{
    public class ProductResolver
    {
        public async Task<bool> GetIsFavoriteAsync(
            [Parent] Product product,
            [Service] FavoriteDataLoader favoriteDataLoader,
            IResolverContext context
        ){
            Console.WriteLine($"[DEBUG] IsFavorite resolver called for product: {product.Id}");

            var userId = context.ContextData.ContainsKey("userId")
                           ? context.ContextData["userId"]?.ToString() ?? "user-123"
                           : "user-123";
            Console.WriteLine($"[DEBUG] Using userId: {userId}");

            var favorites = await favoriteDataLoader.LoadAsync(userId);

            return favorites.Contains(product.Id);
        }
    }
}
