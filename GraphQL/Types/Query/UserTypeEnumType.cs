using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Types.Query
{
    public class UserTypeEnumType : EnumerationGraphType<Data.Entities.UserType>
    {
        public UserTypeEnumType()
        {
            Name = "UserType";
            Description = "The user type";
        }
    }
}