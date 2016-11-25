using BlogSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSystem.Models;
using BlogSystem.Data;

namespace BlogSystem.Services
{
    public class UsersService :BaseService<ApplicationUser>, IUsersService
    {
        public UsersService(IBlogSystemData data)
            :base(data)
        {
        }

    }
}
