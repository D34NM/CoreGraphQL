using System.Collections.Generic;
using System.Linq;
using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Repositories
{
    public interface IOrdersRepository
    {
        IEnumerable<Order> GetForUserId(int id);

        ILookup<int, Order> GetForUsers(IEnumerable<int> ids);
    }
}