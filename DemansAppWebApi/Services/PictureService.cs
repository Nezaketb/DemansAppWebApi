using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;

namespace DemansAppWebApi.Services
{
    public class PictureService : IPictureService
    {
        private readonly IPictureRepository _pictureRepository;
        public PictureService(IPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }
        public async Task<IEnumerable<Pictures>> GetPicturesByUserIdAsync(int userId)
        {
            return await _pictureRepository.GetPicturesByUserIdAsync(userId);
        }
        public async Task AddPictureAsync(Pictures picture)
        {
            await _pictureRepository.AddPictureAsync(picture);
        }
    }
}
