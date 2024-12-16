using BlueOcean.Data;
using BlueOcean.Data.Models;
using BlueOcean.Helpers.Security;
using BlueOcean.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlueOcean.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(BlueOceanDbContext context) : base(context) { }

        public async Task<User?> GetUserAsync(string username, string password)
        {
            User? user = await _context.Users.Where(u => u.Username == username).FirstOrDefaultAsync();
            if (user is null) return null;
            if (!EncryptionUtil.IsValidPassword(password, user.Password)) return null;
            return user;
        }
    }
}
