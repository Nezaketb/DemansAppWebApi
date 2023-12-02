using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface ICommandsRepository
    {
        Task<IEnumerable<Commands>> GetAllAsync();
        Task<IEnumerable<Commands>> GetCommandsByUserIdAsync(int userId);
        Task AddOrderAsync(Commands commands);


    }
}
