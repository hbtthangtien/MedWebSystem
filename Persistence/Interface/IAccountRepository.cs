using Microsoft.AspNetCore.Identity;
using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Interface
{
    public interface IAccountRepository : IGenericRepository<User>
    {
        public UserManager<User> UserManager { get; }
        public SignInManager<User> SignInManager { get; }
    }
}
