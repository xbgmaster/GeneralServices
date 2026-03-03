using Microsoft.EntityFrameworkCore;
using GeneralServices.Data;
using GeneralServices.Entities;
using GeneralServices.Repositories.Interfaces;

namespace GeneralServices.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<GeneralServiceUser?> GetUserAsync(string username, string password)
        {
            return await _context.GeneralServiceUsers
                .FirstOrDefaultAsync(u =>
                    u.UserName == username &&
                    u.Password == password &&
                    u.Status);
        }
    }
}