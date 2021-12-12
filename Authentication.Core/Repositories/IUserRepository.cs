using Authentication.Core.Enums;
using Authentication.Core.Models;

namespace Authentication.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ApplicationRole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
