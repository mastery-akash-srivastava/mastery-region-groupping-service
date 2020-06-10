using Mastery.Region.Entity;
using Mastery.Region.Entity.Models;
using Mastery.Region.Repos.Contracts;

namespace Mastery.Region.Repos.DBContext.Repositories
{
    public class BatchInfoRepository : BaseRepository<BatchInfo>, IBatchInfoRepository
    {
        public BatchInfoRepository(MasteryRegionDbContext _context)
            : base(_context)
        {

        }
    }
}
