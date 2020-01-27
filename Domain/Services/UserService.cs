using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users.Domain.Repositories;
using users.Domain.Services;
using Users.Models;

namespace users.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _userRepository.ListAsync();
        }
    }
}