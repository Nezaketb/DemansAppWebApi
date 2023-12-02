using DemansAppWebApi.Entities;
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
            return await _dbContext.Users.ToListAsync();
        }

        public async Task AddOrderAsync(Users users)
        {
            await _dbContext.Users.AddAsync(users);
            await _dbContext.SaveChangesAsync();
        }
    }
}
