using graphql_dotnet_starter.Models;
using graphql_dotnet_starter.Resolvers;

namespace graphql_dotnet_starter.Types
{
    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Field(p => p.Id);
            descriptor.Field(p => p.Name);

            descriptor.Field("isFavorite")
                .Type<BooleanType>()
                .ResolveWith<ProductResolver>(r => r.GetIsFavoriteAsync(default!, default!, default!));
        }
    }
}
