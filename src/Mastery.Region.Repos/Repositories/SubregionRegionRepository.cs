using Mastery.Region.Entity;
using Mastery.Region.Entity.Models;
using Mastery.Region.Repos.Contracts;

namespace Mastery.Region.Repos.DBContext.Repositories
{
    public class SubregionRegionRepository : BaseRepository<SubregionRegion>, ISubregionRegionRepository
    {
        public SubregionRegionRepository(MasteryRegionDbContext _context)
            :base(_context)
        {

        }
    }
}
