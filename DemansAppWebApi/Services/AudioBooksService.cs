using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;

namespace DemansAppWebApi.Services
{
    public class AudioBooksService : IAudioBooksService
    {
        private readonly IAudioBooksRepository _audioBooksRepository;

        public AudioBooksService(IAudioBooksRepository audioBooksRepository)
        {
            _audioBooksRepository = audioBooksRepository;
        }

        public async Task<IEnumerable<AudioBooks>> GetAllBooksAsync()
        {
            return await _audioBooksRepository.GetAllAsync();
        }

        public async Task AddOrderAsync(AudioBooks audioBooks)
        {
            await _audioBooksRepository.AddOrderAsync(audioBooks);
        }
    }
}
