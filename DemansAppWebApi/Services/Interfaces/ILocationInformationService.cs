using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface ILocationInformationService
    {
        Task<IEnumerable<LocationInformation>> GetAllLocationInformationAsync();
        Task<LocationInformation> GetLocationsByUserIdAsync(int userId);
        Task AddLocationAsync(LocationInformation location);
        Task UpdateLocationAsync(LocationInformation location);

    }
}
