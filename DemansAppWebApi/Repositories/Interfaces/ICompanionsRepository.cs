using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface ICompanionsRepository
    {
        Task<IEnumerable<Companions>> GetAllAsync();
        Task<IEnumerable<Companions>> GetCompanionsByUserIdAsync(int userId);


    }
}
