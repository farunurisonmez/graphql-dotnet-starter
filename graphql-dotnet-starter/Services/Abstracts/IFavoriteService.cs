namespace graphql_dotnet_starter.Service.Abstracts
{
    public interface IFavoriteService
    {
        Task<List<string>> GetFavoriteProductIdsAsync(string userId);
    }
}
