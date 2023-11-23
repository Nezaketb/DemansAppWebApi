using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class MotivationSentencesRepository : IMotivationSentencesRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public MotivationSentencesRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<MotivationSentences>> GetAllAsync()
        {
            return await _dbContext.MotivationSentences.ToListAsync();
        }
    }
}
