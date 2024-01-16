using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories;
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
        public async Task AddUserAsync(Users users)
        {
            await _userRepository.AddUserAsync(users);
        }

        public async Task<bool> UpdateUserAsync(Users user)
        {
            await _userRepository.UpdateUserAsync(user);
            return true;
        }
        public async Task RegisterAsync(string username, string email, string password)
        {
            var existingUser = await _userRepository.GetUserByEmailAsync(email);
            if (existingUser != null)
            {
                throw new Exception("Bu e-posta adresi ile bir kullanıcı zaten var.");
            }


            var newUser = new Users
            {
                UserName = username,
                Email = email,
                Password = password
            };

            await _userRepository.CreateUserAsync(newUser);
        }

        public async Task<Users> AuthenticateAsync(string email, string password)
        {
            var user = await _userRepository.GetByEmailAndPasswordAsync(email, password);

            return user;
        }

    }
}
