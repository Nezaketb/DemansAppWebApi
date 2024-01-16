using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<Users>> GetAllUsersAsync();
        Task AddUserAsync(Users users);
        Task<bool> UpdateUserAsync(Users user);
        Task RegisterAsync(string username, string email, string password);
        Task<Users> AuthenticateAsync(string email, string password);
    }
}
