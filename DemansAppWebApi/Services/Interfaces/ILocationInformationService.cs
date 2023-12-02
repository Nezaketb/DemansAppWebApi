using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface ILocationInformationService
    {
        Task<IEnumerable<LocationInformation>> GetAllLocationInformationAsync();
        Task<IEnumerable<LocationInformation>> GetLocationsByUserIdAsync(int userId);
        Task AddOrderAsync(LocationInformation location);

    }
}
