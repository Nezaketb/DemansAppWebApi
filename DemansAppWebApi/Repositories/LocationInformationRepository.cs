using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class LocationInformationRepository:ILocationInformationRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public LocationInformationRepository(DemansAppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<LocationInformation>> GetAllAsync()
        {
            return await _dbContext.LocationInformation.ToListAsync();
        }

        public async Task<LocationInformation> GetLocationByUserIdAsync(int userId)
        {
            return await _dbContext.LocationInformation
                .Where(ss => ss.UserId == userId)
                .OrderByDescending(ss => ss.Id)
                .FirstOrDefaultAsync();
        }


        public async Task AddLocationAsync(LocationInformation location)
        {
            await _dbContext.LocationInformation.AddAsync(location);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateLocationAsync(LocationInformation location)
        {
            _dbContext.LocationInformation.Update(location);
            await _dbContext.SaveChangesAsync();
        }
    }
}
