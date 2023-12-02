using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface IMotivationSentencesService
    {
        Task<IEnumerable<MotivationSentences>> GetAllStoresAsync();
        Task AddOrderAsync(MotivationSentences sentences);

    }
}
