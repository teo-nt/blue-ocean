using Microsoft.EntityFrameworkCore;

namespace BlueOcean.Data
{
    public class BlueOceanDbContext : DbContext
    {
        public BlueOceanDbContext(DbContextOptions<BlueOceanDbContext> options) : base(options) { }

    }
}
