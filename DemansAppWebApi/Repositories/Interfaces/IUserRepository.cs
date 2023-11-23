using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetAllAsync();

    }
}
