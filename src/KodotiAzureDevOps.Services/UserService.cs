using KodotiAzureDevOps.Models;
using KodotiAzureDevOps.Services.InMemoryData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KodotiAzureDevOps.Services
{
    public class UserService
    {
        public List<User> GetAll()
        {
            return ApplicationDbContext.Users;
        }

        public User Get(Guid id)
        {
            return ApplicationDbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
