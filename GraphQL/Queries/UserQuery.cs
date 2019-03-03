using CoreGraphQL.GraphQL.Types;
using CoreGraphQL.Repositories;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Queries
{
    public sealed class UserQuery : ObjectGraphType
    {
        public UserQuery(IUserRepository userRepository, IOrdersRepository ordersRepository)
        {
            Field<ListGraphType<UserType>>()
                .Name("users")
                .Description("Get all users")
                .Resolve(_ => userRepository.GetAll());

            Field<UserType>()
                .Name("user")
                .Description("Get single user with id")
                .Argument<NonNullGraphType<IdGraphType>>("id", "The id of the user")
                .Resolve(context =>
                {
                    var id = context.GetArgument<int>("id");

                    var user = userRepository.GetById(id);
                    user.Orders = ordersRepository.GetForUserId(id);
                        
                    return user;
                });
        }
    }
}