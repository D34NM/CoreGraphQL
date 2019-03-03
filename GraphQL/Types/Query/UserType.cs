using System.Collections.Generic;
using System.Threading.Tasks;
using CoreGraphQL.Data.Entities;
using CoreGraphQL.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Types.Query
{
    public sealed class UserType : ObjectGraphType<User>
    {
        public UserType(IAddressRepository addressRepository, IOrdersRepository ordersRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(m => m.Id).Description("The user unique id");
            Field(m => m.FirstName).Description("The users first name");
            Field(m => m.LastName).Description("The users last name");
            Field(m => m.DateOfBirth).Description("The users date of birth");
            Field<UserTypeEnumType>("UserType", "The type of the user");
            Field<AddressType, Address>()
                .Name("address")
                .Description("The address of the user")
                .ResolveAsync(context => Task.FromResult(addressRepository.GetById(context.Source.Id)));
            Field<ListGraphType<OrderType>, IEnumerable<Order>>()
                .Name("orders")
                .Description("The orders made by the user")
                .ResolveAsync(context =>
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, Order>(
                        "GetOrdersForUsers",
                        keys => Task.FromResult(ordersRepository.GetForUsers(keys)),
                        null);

                    return loader.LoadAsync(context.Source.Id);
                });
        }
    }
}