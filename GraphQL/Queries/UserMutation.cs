using System.Threading.Tasks;
using CoreGraphQL.Data.Entities;
using CoreGraphQL.GraphQL.Types.Query;
using CoreGraphQL.Repositories;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Queries
{
    public class UserMutation : ObjectGraphType
    {
        public UserMutation(IOrdersRepository ordersRepository)
        {
            FieldAsync<OrderType>(
                "createOrder",
                "Insert a new order of the user",
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<Types.Input.OrderType>>
                    {
                        Name = "order"
                    }),
                async context =>
                {
                    var order = context.GetArgument<Order>("order");
                    return await context.TryAsyncResolve(
                        async _ => await Task.FromResult(ordersRepository.Add(order)));
                });

        }
    }
}