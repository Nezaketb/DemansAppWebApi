using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class PicturesRepository : IPictureRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public PicturesRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

  
        public async Task<IEnumerable<Pictures>> GetPicturesByUserIdAsync(int userId)
        {
            return await _dbContext.Pictures
            .Where(ss => ss.UserId == userId)
            .ToListAsync();
        }

        public async Task AddPictureAsync(Pictures picture)
        {
            await _dbContext.Pictures.AddAsync(picture);
            await _dbContext.SaveChangesAsync();
        }

    }
}
