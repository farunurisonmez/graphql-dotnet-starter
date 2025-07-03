using graphql_dotnet_starter.Service.Abstracts;

namespace graphql_dotnet_starter.DataLoaders
{
    public class FavoriteDataLoader : BatchDataLoader<string, List<string>>
    {
        private readonly IFavoriteService _favoriteService;

        public FavoriteDataLoader(IFavoriteService favoriteService, IBatchScheduler batchScheduler, DataLoaderOptions? options = null)
            : base(batchScheduler, options)
        {
            _favoriteService = favoriteService;
        }

        protected override async Task<IReadOnlyDictionary<string, List<string>>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            Console.WriteLine($"[DEBUG] DataLoader called with keys: {string.Join(", ", keys)}");

            var result = new Dictionary<string, List<string>>();

            foreach (var userId in keys)
            {
                var favorites = await _favoriteService.GetFavoriteProductIdsAsync(userId);
                result[userId] = favorites;
            }

            return result;
        }
    }
}
