using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;

namespace DemansAppWebApi.Services
{
    public class MedicinesService : IMedicinesService
    {
        private readonly IMedicinesRepository _medicinesRepository;
        public MedicinesService(IMedicinesRepository medicinesRepository)
        {
            _medicinesRepository = medicinesRepository;
        }
        public async Task<IEnumerable<Medicines>> GetAllMedicinesAsync()
        {
            return await _medicinesRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Medicines>> GetMedicinesByUserIdAsync(int userId)
        {
            return await _medicinesRepository.GetMedicinesByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Medicines>> GetMedicinesNearExpiration(DateTime currentDate)
        {
            return await _medicinesRepository.GetMedicinesNearExpiration(currentDate);
        }
        public async Task AddMedicineAsync(Medicines medicines)
        {
            await _medicinesRepository.AddMedicineAsync(medicines);
        }

        public async Task UpdateMedicineAsync(Medicines medicine)
        {
            await _medicinesRepository.UpdateMedicineAsync(medicine);
        }
    }
}
