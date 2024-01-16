using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface IPictureRepository
    {
        Task<IEnumerable<Pictures>> GetPicturesByUserIdAsync(int userId);
        Task AddPictureAsync(Pictures picture);
    }
}
