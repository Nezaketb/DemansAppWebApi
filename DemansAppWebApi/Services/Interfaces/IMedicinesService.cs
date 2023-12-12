using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface IMedicinesService
    {
        Task<IEnumerable<Medicines>> GetAllMedicinesAsync();
        Task<IEnumerable<Medicines>> GetMedicinesByUserIdAsync(int userId);
        Task AddMedicineAsync(Medicines medicines);
        Task UpdateMedicineAsync(Medicines medicine);

    }
}
