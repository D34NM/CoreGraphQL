using System;
using System.Linq;
using CoreGraphQL.Data.Entities;
using FizzWare.NBuilder;

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
                BuilderSetup.DisablePropertyNamingFor<Address, int>(a => a.Id);
                BuilderSetup.DisablePropertyNamingFor<Order, int>(o => o.Id);
                BuilderSetup.DisablePropertyNamingFor<Order, int>(o => o.UserId);
                BuilderSetup.DisablePropertyNamingFor<Order, User>(o => o.User);
                BuilderSetup.DisablePropertyNamingFor<User, int>(u => u.Id);
                
                var address = Builder<Address>.CreateNew().Build();

                var orders = Builder<Order>.CreateListOfSize(5).Build();

                var user = Builder<User>.CreateNew()
                    .With(u => u.Address, address)
                    .With(u => u.Orders, orders)
                    .With(u => u.DateOfBirth, DateTime.Now.AddDays(new Random().Next(i, HowMany)))
                    .Build();

                context.Orders.AddRange(orders);
                context.Addresses.Add(address);
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}