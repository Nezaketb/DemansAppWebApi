using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;

namespace DemansAppWebApi.Services
{
    public class UsersServices : IUsersService
    {
        private readonly IUserRepository _userRepository;
        public UsersServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
