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
                "users",
                "Query all users",
                null,
                _ => userRepository.GetAll() 
                );
        }
    }
}