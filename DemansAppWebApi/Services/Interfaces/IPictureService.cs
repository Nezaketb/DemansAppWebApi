using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface IPictureService
    {
        Task<IEnumerable<Pictures>> GetPicturesByUserIdAsync(int userId);
        Task AddPictureAsync(Pictures picture);
    }
}
