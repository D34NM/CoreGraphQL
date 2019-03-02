using System.Collections.Generic;
using CoreGraphQL.Data;
using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Repositories
{
    public sealed class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext userDbContext)
        {
            _context = userDbContext;
        }
        
        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}