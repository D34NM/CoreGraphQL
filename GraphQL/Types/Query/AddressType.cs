using CoreGraphQL.Data.Entities;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Types.Query
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Field(m => m.Id);
            Field(m => m.City);
            Field(m => m.Street);
        }
    }
}