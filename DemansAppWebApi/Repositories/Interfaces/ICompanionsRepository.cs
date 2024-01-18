using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface ICompanionsRepository
    {
        Task<IEnumerable<Companions>> GetAllAsync();
        Task<IEnumerable<Companions>> GetCompanionsByUserIdAsync(int userId);
        Task AddCompanionAsync(Companions companions);
        Task<Companions> GetByEmailAndPasswordAsync(string email, string password);

        Task UpdateCompanionAsync(Companions companion);
    }
}
