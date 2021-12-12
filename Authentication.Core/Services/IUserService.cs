using Authentication.Core.Enums;
using Authentication.Core.Models;
using Authentication.Core.Responses;

namespace Authentication.Core.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ApplicationRole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
