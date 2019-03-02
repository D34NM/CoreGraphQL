using System;
using System.Linq;
using CoreGraphQL.Data.Entities;

namespace CoreGraphQL.Data
{
    public static class SeedDataExtensions
    {
        private const int HowMany = 100;
        
        public static void Seed(this UserDbContext context)
        {
            if (!context.Users.Any())
            {
                for (var i = 0; i < HowMany; i++)
                {
                    context.Users.Add(new User
                    {
                        FirstName = $"First {i}",
                        LastName = $"Last {i}",
                        DateOfBirth = DateTime.Now.AddDays(i)
                    });
                }

                context.SaveChanges();
            }
        }
    }
}