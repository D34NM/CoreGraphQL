using CoreGraphQL.Data.Entities;
using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Types
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType()
        {
            Field(m => m.Id);
            Field(m => m.Item);
            Field(m => m.Price);
        }
    }
}