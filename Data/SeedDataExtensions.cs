using System;
using System.Linq;
using CoreGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreGraphQL.Data
{
    public static class SeedDataExtensions
    {
        private const int HowMany = 100;
        
        public static void Seed(this UserDbContext context)
        {
            if (context.Users.Any()) return;
            
            for (var i = 0; i < HowMany; i++)
            {
                var address = new Address
                {
                    City = $"City {i}",
                    Street = $"Street {i}"
                };
                
                var user = new User
                {
                    FirstName = $"First {i}",
                    LastName = $"Last {i}",
                    DateOfBirth = DateTime.Now.AddDays(i),
                    UserType = i % 5 == 0 ? UserType.Admin : UserType.Regular,
                    Address = address
                };

                context.Addresses.Add(address);
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}