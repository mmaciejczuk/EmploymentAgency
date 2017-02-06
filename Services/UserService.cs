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
        private EAContext context = new EAContext();
        public IQueryable<User> GetUsers()
        {
            var users = from o in context.User select o;
            return users;
        }
    }
}
