using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemansAppWebApi.Services
{
    public class MotivationSentencesService:IMotivationSentencesService
    {
        private readonly IMotivationSentencesRepository _sentenceRepository;
        public MotivationSentencesService(IMotivationSentencesRepository sentenceRepository)
        {
            _sentenceRepository = sentenceRepository;
        }
        public async Task<IEnumerable<MotivationSentences>> GetAllStoresAsync()
        {
            return await _sentenceRepository.GetAllAsync();
        }
    }
}
