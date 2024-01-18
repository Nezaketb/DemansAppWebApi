using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetAllAsync();
        Task AddUserAsync(Users users);
        Task UpdateUserAsync(Users user);
        Task<Users> GetUserByIdAsync(int userId);
        Task<Users> GetUserByEmailAsync(string email);
        Task<Users> GetByEmailAndPasswordAsync(string email,string password);
        Task CreateUserAsync(Users user);
    }
}
