using System.Collections.Generic;
using System.Linq;
using CoreGraphQL.Data;
using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private UserDbContext _context;

        public OrdersRepository(UserDbContext userDbContext)
        {
            _context = userDbContext;
        }

        public IEnumerable<Order> GetForUserId(int id)
        {
            return _context.Orders.Where(order => order.UserId == id);
        }

        public ILookup<int, Order> GetForUsers(IEnumerable<int> ids)
        {
            var orders = _context.Orders.Where(order => ids.Contains(order.Id));
            return orders.ToLookup(order => order.Id);
        }
    }
}