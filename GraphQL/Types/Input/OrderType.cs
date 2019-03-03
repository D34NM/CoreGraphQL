using GraphQL.Types;

namespace CoreGraphQL.GraphQL.Types.Input
{
    public class OrderType : InputObjectGraphType
    {
        public OrderType()
        {
            Name = "orderInput";
            Field<NonNullGraphType<StringGraphType>>("item");
            Field<NonNullGraphType<IntGraphType>>("price");
            Field<NonNullGraphType<IntGraphType>>("userId");
        }
    }
}