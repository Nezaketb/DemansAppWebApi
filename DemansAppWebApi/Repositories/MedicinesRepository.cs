using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class MedicinesRepository:IMedicinesRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public MedicinesRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Medicines>> GetAllAsync()
        {
            return await _dbContext.Medicines.ToListAsync();
        }

        public async Task<IEnumerable<Medicines>> GetMedicinesByUserIdAsync(int userId)
        {
            return await _dbContext.Medicines
            .Where(ss => ss.UserId == userId)
            .ToListAsync();
        }

        public async Task<IEnumerable<Medicines>> GetMedicinesNearExpiration(DateTime currentDate)
        {
            return await _dbContext.Medicines
                .Where(m => m.EndDate >= currentDate && m.EndDate <= currentDate.AddDays(7)) 
            .OrderBy(m => m.EndDate)  
            .Take(3) 
            .ToListAsync();
        }
        public async Task AddMedicineAsync(Medicines medicines)
        {
            await _dbContext.Medicines.AddAsync(medicines);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateMedicineAsync(Medicines medicine)
        {
            _dbContext.Medicines.Update(medicine);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Medicines>> MedicineControl(int userId)
        {

            return await _dbContext.Medicines
               .Where(m => m.UserId == userId && m.EndDate >= DateTime.Now && m.StartDate <= DateTime.Now).ToListAsync();
            
        }
    }
}
