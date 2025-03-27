using Microsoft.AspNetCore.Identity;
using Persistence.Config;
using Persistence.Entities;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class AccountRepository : GenericRepository<User>, IAccountRepository
    {
        public UserManager<User> UserManager { get; set; }
        public SignInManager<User> SignInManager { get; set; }

        public AccountRepository(MedSystemContext funewsManagementContext,
            SignInManager<User> signInManager,
            UserManager<User> userManager) : base(funewsManagementContext)
        {
            SignInManager = signInManager;
            UserManager = userManager;
        }

    }
}
