﻿using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class AudioBooksRepository:IAudioBooksRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public AudioBooksRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<AudioBooks>> GetAllAsync()
        {
            return await _dbContext.AudioBooks.ToListAsync();
            
        }
        public async Task AddBookAsync(AudioBooks audioBooks)
        {
            await _dbContext.AudioBooks.AddAsync(audioBooks);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(AudioBooks book)
        {
            _dbContext.AudioBooks.Update(book);
            await _dbContext.SaveChangesAsync();
        }
    }
}
