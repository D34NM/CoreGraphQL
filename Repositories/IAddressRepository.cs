using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Repositories
{
    public interface IAddressRepository
    {
        Address GetById(int id);
    }
}