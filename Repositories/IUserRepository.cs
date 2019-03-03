using System.Collections.Generic;
using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);
        IEnumerable<User> GetAll();
    }
}