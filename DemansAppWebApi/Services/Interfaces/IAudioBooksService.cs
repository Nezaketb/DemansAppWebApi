using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface IAudioBooksService
    {
        Task<IEnumerable<AudioBooks>> GetAllBooksAsync();
        Task AddBookAsync(AudioBooks audioBooks);

    }
}
