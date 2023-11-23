using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface ILocationInformationRepository
    {
        Task<IEnumerable<LocationInformation>> GetAllAsync();
        Task<IEnumerable<LocationInformation>> GetLocationByUserIdAsync(int userId);


    }
}
