using System.Collections.Generic;
using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}