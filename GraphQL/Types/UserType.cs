using CoreGraphQL.Data.Entities;
using CoreGraphQL.Repositories;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Types
{
    public sealed class UserType : ObjectGraphType<User>
    {
        public UserType(IAddressRepository addressRepository)
        {
            Field(m => m.Id).Description("The user unique id");
            Field(m => m.FirstName).Description("The users first name");
            Field(m => m.LastName).Description("The users last name");
            Field(m => m.DateOfBirth).Description("The users date of birth");
            Field<UserTypeEnumType>("UserType", "The type of the user");
            Field<AddressType>(
                "address",
                "The address of the user",
                null,
                context => addressRepository.GetById(context.Source.Id));
        }
    }
}