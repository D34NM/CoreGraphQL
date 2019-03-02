using CoreGraphQL.Data.Entities;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Types
{
    public sealed class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(m => m.Id);
            Field(m => m.FirstName);
            Field(m => m.LastName);
            Field(m => m.DateOfBirth);
        }
    }
}