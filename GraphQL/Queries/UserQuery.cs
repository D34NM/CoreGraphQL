using CoreGraphQL.GraphQL.Types;
using CoreGraphQL.Repositories;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Queries
{
    public sealed class UserQuery : ObjectGraphType
    {
        public UserQuery(IUserRepository userRepository)
        {
            Field<ListGraphType<UserType>>(
                "products",
                "Query all products",
                null,
                _ => userRepository.GetAll() 
                );
        }
    }
}