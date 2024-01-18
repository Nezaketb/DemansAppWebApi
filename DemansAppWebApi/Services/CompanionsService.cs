using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;

namespace DemansAppWebApi.Services
{
    public class CompanionsService : ICompanionsService
    {
        private readonly ICompanionsRepository _companionsRepository;
        public CompanionsService(ICompanionsRepository companionsRepository)
        {
            _companionsRepository = companionsRepository;
        }

        public async Task<IEnumerable<Companions>> GetAllCompanionsAsync()
        {
            return await _companionsRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Companions>> GetCompanionsByUserIdAsync(int userId)
        {
            return await _companionsRepository.GetCompanionsByUserIdAsync(userId);
        }
        public async Task AddCompanionAsync(Companions companions)
        {
            await _companionsRepository.AddCompanionAsync(companions);
        }

        public async Task UpdateCompanionAsync(Companions companion)
        {
            await _companionsRepository.UpdateCompanionAsync(companion);
        }

        public async Task<Companions> AuthenticateAsync(string email, string password)
        {
            var user = await _companionsRepository.GetByEmailAndPasswordAsync(email, password);

            return user;
        }

    }
}
