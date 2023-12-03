using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Services.Interfaces
{
    public interface IMotivationSentencesService
    {
        Task<IEnumerable<MotivationSentences>> GetAllSentencesAsync();
        Task AddSentenceAsync(MotivationSentences sentences);

    }
}
