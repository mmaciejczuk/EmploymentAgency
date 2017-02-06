using Repository.Models;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        public IQueryable<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
