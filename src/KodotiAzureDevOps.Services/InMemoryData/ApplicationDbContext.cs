using Faker;
using KodotiAzureDevOps.Models;
using System;
using System.Collections.Generic;

namespace KodotiAzureDevOps.Services.InMemoryData
{
    public class ApplicationDbContext
    {
        private static List<User> _data;

        public static List<User> Users 
        {
            get {
                return _data;
            }
        }

        public static void Initialize() 
        {
            if (_data == null)
            {
                _data = new List<User>();

                for (var i = 1; i <= 25; i++)
                {
                    _data.Add(new User
                    {
                        Id = Guid.NewGuid(),
                        Name = Name.First(),
                        LastName = Name.Last(),
                        Address = Address.StreetAddress(),
                        City = Address.City(),
                        Email = Internet.Email(),
                        Birthday = Identification.DateOfBirth(),
                        MedicareBeneficaryNumber = Identification.MedicareBeneficiaryIdentifier(),
                        SocialSecurityNumber = Identification.SocialSecurityNumber(),
                        Passport = Identification.UsPassportNumber(),
                        Salary = RandomNumber.Next(2000, 12000)
                    });
                }
            }
        }
    }
}
