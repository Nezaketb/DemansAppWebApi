using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class CompanionsRepository:ICompanionsRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public CompanionsRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Companions>> GetAllAsync()
        {
            return await _dbContext.Companions.ToListAsync();
        }

        public async Task<IEnumerable<Companions>> GetCompanionsByUserIdAsync(int userId)
        {
            return await _dbContext.Companions
            .Where(ss => ss.UserId == userId)
            .ToListAsync();
        }

        public async Task AddOrderAsync(Companions companions)
        {
            await _dbContext.Companions.AddAsync(companions);
            await _dbContext.SaveChangesAsync();
        }
    }
}
