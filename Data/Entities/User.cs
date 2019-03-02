using System;

namespace CoreGraphQL.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public UserType UserType { get; set; }
        public Address Address { get; set; }
    }
}