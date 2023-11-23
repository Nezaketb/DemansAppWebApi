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
    }
}
