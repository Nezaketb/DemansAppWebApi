using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class AudioBooksRepository:IAudioBooksRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public AudioBooksRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<AudioBooks>> GetAllAsync()
        {
            return await _dbContext.AudioBooks.ToListAsync();
        }
    }
}
