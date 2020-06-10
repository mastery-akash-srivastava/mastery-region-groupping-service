using Mastery.Region.Entity;
using Mastery.Region.Entity.Models;
using Mastery.Region.Repos.Contracts;

namespace Mastery.Region.Repos.DBContext.Repositories
{
    public class RegionSuperRegionRepository : BaseRepository<RegionSuperRegion>,IRegionSuperRegionRepository
    {
        public RegionSuperRegionRepository(MasteryRegionDbContext _context)
            :base(_context)
        {

        }
    }
}
