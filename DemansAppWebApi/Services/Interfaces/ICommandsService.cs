using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface ICommandsService
    {
        Task<IEnumerable<Commands>> GetAllCommandsAsync();
        Task<IEnumerable<Commands>> GetCommandsByUserIdAsync(int userId);


    }
}
