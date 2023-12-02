using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class CommandsRepository:ICommandsRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public CommandsRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Commands>> GetAllAsync()
        {
            return await _dbContext.Commands.ToListAsync();
        }

        public async Task<IEnumerable<Commands>> GetCommandsByUserIdAsync(int userId)
        {
            return await _dbContext.Commands
            .Where(ss => ss.UserId == userId)
            .ToListAsync();
        }
        public async Task AddOrderAsync(Commands commands)
        {
            await _dbContext.Commands.AddAsync(commands);
            await _dbContext.SaveChangesAsync();
        }
    }
}
