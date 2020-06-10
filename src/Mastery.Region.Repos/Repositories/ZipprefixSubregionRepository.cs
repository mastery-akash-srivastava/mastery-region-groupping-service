using Mastery.Region.Entity;
using Mastery.Region.Entity.Models;
using Mastery.Region.Repos.Contracts;

namespace Mastery.Region.Repos.DBContext.Repositories
{
    public class ZipprefixSubregionRepository : BaseRepository<ZipprefixSubregion>, IZipprefixSubregionRepository
    {
        public ZipprefixSubregionRepository(MasteryRegionDbContext _context)
            :base(_context)
        {

        }
    }
}
