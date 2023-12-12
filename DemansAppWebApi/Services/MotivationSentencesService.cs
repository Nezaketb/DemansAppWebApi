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
        public async Task<IEnumerable<MotivationSentences>> GetAllSentencesAsync()
        {
            return await _sentenceRepository.GetAllAsync();
        }
        public async Task AddSentenceAsync(MotivationSentences sentences)
        {
            await _sentenceRepository.AddSentenceAsync(sentences);
        }

        public async Task UpdateSentenceAsync(MotivationSentences sentence)
        {
            await _sentenceRepository.UpdateSentenceAsync(sentence);
        }
    }
}
