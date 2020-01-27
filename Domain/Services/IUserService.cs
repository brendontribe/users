using System.Collections.Generic;
using System.Threading.Tasks;
using Users.Models;

namespace users.Domain.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> ListAsync();
    }
}