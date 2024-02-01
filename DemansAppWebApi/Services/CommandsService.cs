using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;
using System;

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
        public async Task AddCommandAsync(int userId)
        {
            Commands companion1 = new()
            {
                ProcessName = "Elektrik",
                Status = 0,
                UserId = userId,
            };
            await _commandsRepository.AddCommandAsync(companion1);

            Commands companion2 = new()
            {
                ProcessName = "Doğalgaz",
                Status = 0, 
                UserId = userId,
            };
            await _commandsRepository.AddCommandAsync(companion2);
        }

        public async Task UpdateCommandAsync(Commands commands)
        {
            await _commandsRepository.UpdateCommandAsync(commands);
        }
    }
}
