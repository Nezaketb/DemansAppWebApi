﻿using DemansAppWebApi.Entities;
using DemansAppWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemansAppWebApi.Repositories
{
    public class UsersRepository:IUserRepository
    {
        private readonly DemansAppDbContext _dbContext;

        public UsersRepository(DemansAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Users>> GetAllAsync()
        {
            try
            {
                // ... Diğer kodlar

                var users = await _dbContext.Users.ToListAsync();

                // ... Diğer kodlar

                return users;
            }
            catch (Exception ex)
            {
                // Hata mesajını loglama
                Console.WriteLine($"Exception: {ex.Message}");
                // Hata mesajını döndürme
                throw new Exception("An error occurred while fetching users.", ex);
            }

        }


        public async Task AddUserAsync(Users users)
        {
            await _dbContext.Users.AddAsync(users);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateUserAsync(Users user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Users> GetUserByIdAsync(int userId)
        {
            return await _dbContext.Users.FindAsync(userId);
        }

        public async Task<Users> GetUserByEmailAsync(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<Users> GetByEmailAndPasswordAsync(string email, string password)
        {
            // Kullanıcıyı e-posta ve şifre ile ara
            var user = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

            return user;
        }
        public async Task CreateUserAsync(Users user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
