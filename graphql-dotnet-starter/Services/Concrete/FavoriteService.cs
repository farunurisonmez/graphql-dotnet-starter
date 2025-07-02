using graphql_dotnet_starter.Service.Abstracts;

namespace graphql_dotnet_starter.Services.Concrete
{
    public class FavoriteService : IFavoriteService
    {
        public Task<List<string>> GetFavoriteProductIdsAsync(string userId)
        {
            var favorites = new Dictionary<string, List<string>>
            {
                ["user-123"] = new() { "1", "3" },
                ["user-abc"] = new() { "2" }
            };

            return Task.FromResult(favorites.ContainsKey(userId) ? favorites[userId] : new List<string>());
        }
    }
}
