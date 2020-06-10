using Mastery.Region.Entity;
using Mastery.Region.Repos.DBContext.Repositories;
using Mastery.Region.Repos.Contracts;

namespace Mastery.Region.Repos.DBContext
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MasteryRegionDbContext _context;
        private IBatchInfoRepository _batchInfo;
        private ISubregionRegionRepository _subregionRegion;
        private IRegionSuperRegionRepository _regionSuperRegion;
        private ISuperRegionRepository _superRegion;
        private IZipprefixSubregionRepository _zipprefixSubregion;

        public IBatchInfoRepository BatchInfo
        {
            get
            {
                if (_batchInfo == null)
                {
                    _batchInfo = new BatchInfoRepository(_context);
                }
                return _batchInfo;
            }
        }
        public ISubregionRegionRepository SubregionRegion
        {
            get
            {
                if (_subregionRegion == null)
                {
                    _subregionRegion = new SubregionRegionRepository(_context);
                }
                return _subregionRegion;
            }
        }
        public IRegionSuperRegionRepository RegionSuperRegion
        {
            get
            {
                if (_regionSuperRegion == null)
                {
                    _regionSuperRegion = new RegionSuperRegionRepository(_context);
                }
                return _regionSuperRegion;
            }
        }
        public ISuperRegionRepository SuperRegion
        {
            get
            {
                if (_superRegion == null)
                {
                    _superRegion = new SuperRegionRepository(_context);
                }
                return _superRegion;
            }
        }
        public IZipprefixSubregionRepository ZipprefixSubregion
        {
            get
            {
                if(_zipprefixSubregion == null)
                {
                    _zipprefixSubregion = new ZipprefixSubregionRepository(_context);
                }
                return _zipprefixSubregion;
            }
        }

        public RepositoryWrapper(MasteryRegionDbContext masteryRegionContext)
        {
            _context = masteryRegionContext;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
