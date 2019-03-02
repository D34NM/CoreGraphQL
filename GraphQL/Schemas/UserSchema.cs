using CoreGraphQL.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Schemas
{
    public class UserSchema : Schema
    {
        public UserSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<UserQuery>();
        }
    }
}