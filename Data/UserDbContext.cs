using CoreGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreGraphQL.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) 
            : base(options)
        { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}