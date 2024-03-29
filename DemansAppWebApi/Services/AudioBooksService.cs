﻿using DemansAppWebApi.Entities;
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

        public async Task AddBookAsync(AudioBooks audioBooks)
        {
            await _audioBooksRepository.AddBookAsync(audioBooks);
        }

        public async Task UpdateBookAsync(AudioBooks audioBooks)
        {
            await _audioBooksRepository.UpdateBookAsync(audioBooks);
        }
    }
}
