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

        public async Task<IEnumerable<LocationInformation>> GetLocationByUserIdAsync(int userId)
        {
            return await _dbContext.LocationInformation
            .Where(ss => ss.UserId == userId)
            .ToListAsync();
        }
    }
}
