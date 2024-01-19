using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface IMedicinesRepository
    {
        Task<IEnumerable<Medicines>> GetAllAsync();
        Task<IEnumerable<Medicines>> GetMedicinesByUserIdAsync(int userId);
        Task AddMedicineAsync(Medicines medicines);
        Task UpdateMedicineAsync(Medicines medicine);
        Task<IEnumerable<Medicines>> GetMedicinesNearExpiration(DateTime currentDate);

    }
}
