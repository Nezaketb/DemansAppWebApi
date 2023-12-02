using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface IMotivationSentencesRepository
    {
        Task<IEnumerable<MotivationSentences>> GetAllAsync();
        Task AddOrderAsync(MotivationSentences sentences);

    }
}
