using System.Linq;
using CoreGraphQL.Data;
using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly UserDbContext _context;
        
        public AddressRepository(UserDbContext userDbContext)
        {
            _context = userDbContext;
        }
        
        public Address GetById(int id)
        {
            return _context.Addresses.First(address => address.Id == id);
        }
    }
}