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

        public async Task AddSentenceAsync(MotivationSentences sentences)
        {
            await _dbContext.MotivationSentences.AddAsync(sentences);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSentenceAsync(MotivationSentences sentence)
        {
            _dbContext.MotivationSentences.Update(sentence);
            await _dbContext.SaveChangesAsync();
        }
    }
}
