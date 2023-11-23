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
    }
}
