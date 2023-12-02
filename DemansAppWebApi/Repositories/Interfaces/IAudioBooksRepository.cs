﻿using DemansAppWebApi.Entities;

namespace DemansAppWebApi.Repositories.Interfaces
{
    public interface IAudioBooksRepository
    {
        Task<IEnumerable<AudioBooks>> GetAllAsync();
        Task AddOrderAsync(AudioBooks audioBooks);


    }
}
