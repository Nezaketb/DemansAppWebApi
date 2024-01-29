using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;

namespace DemansAppWebApi.Services
{
    public class LocationInformationService : ILocationInformationService
    {
        private readonly ILocationInformationRepository _locationInformationRepository;

        public LocationInformationService(ILocationInformationRepository locationInformationRepository)
        {
            _locationInformationRepository = locationInformationRepository;
        }
        public async Task<IEnumerable<LocationInformation>> GetAllLocationInformationAsync()
        {
            return await _locationInformationRepository.GetAllAsync();
        }

        public async Task<LocationInformation> GetLocationsByUserIdAsync(int userId)
        {
            return await _locationInformationRepository.GetLocationByUserIdAsync(userId);
        }
        public async Task AddLocationAsync(LocationInformation location)
        {
            await _locationInformationRepository.AddLocationAsync(location);
        }

        public async Task UpdateLocationAsync(LocationInformation location)
        {
            await _locationInformationRepository.UpdateLocationAsync(location);
        }
    }
}
