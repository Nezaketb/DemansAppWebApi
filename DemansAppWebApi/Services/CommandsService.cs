using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;

namespace DemansAppWebApi.Services
{
    public class CommandsService : ICommandsService
    {
        private readonly ICommandsRepository _commandsRepository;
        public CommandsService(ICommandsRepository commandsRepository)
        {
            _commandsRepository = commandsRepository;
        }
        public async Task<IEnumerable<Commands>> GetAllCommandsAsync()
        {
            return await _commandsRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Commands>> GetCommandsByUserIdAsync(int userId)
        {
            return await _commandsRepository.GetCommandsByUserIdAsync(userId);
        }
    }
}
