using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface ICompanionsService
    {
        Task<IEnumerable<Companions>> GetAllCompanionsAsync();
        Task<IEnumerable<Companions>> GetCompanionsByUserIdAsync(int userId);
        Task AddCompanionAsync(Companions companions);
    }
}
