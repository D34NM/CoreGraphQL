using System.Collections.Generic;
using System.Linq;
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

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}