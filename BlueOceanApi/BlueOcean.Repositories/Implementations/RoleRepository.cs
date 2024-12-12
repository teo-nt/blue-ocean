using BlueOcean.Data;
using BlueOcean.Data.Models;
using BlueOcean.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.Repositories.Implementations
{
    public class RoleRepository: BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(BlueOceanDbContext context): base(context)
        {
            
        }
    }
}
