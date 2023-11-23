using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface IMedicinesRepository
    {
        Task<IEnumerable<Medicines>> GetAllAsync();
        Task<IEnumerable<Medicines>> GetMedicinesByUserIdAsync(int userId);


    }
}
