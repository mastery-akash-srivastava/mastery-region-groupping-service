using Mastery.Region.Entity;
using Mastery.Region.Entity.Models;
using Mastery.Region.Repos.Contracts;

namespace Mastery.Region.Repos.DBContext.Repositories
{
    public class SuperRegionRepository : BaseRepository<SuperRegion>,ISuperRegionRepository
    {
        public SuperRegionRepository(MasteryRegionDbContext _context)
            :base(_context)
        {

        }
    }
}
