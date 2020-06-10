
namespace Mastery.Region.Repos.Contracts
{
    public interface IRepositoryWrapper
    {
        IBatchInfoRepository BatchInfo { get; }
        ISubregionRegionRepository SubregionRegion { get; }
        IRegionSuperRegionRepository RegionSuperRegion { get; }
        ISuperRegionRepository SuperRegion { get; }
        IZipprefixSubregionRepository ZipprefixSubregion { get; }
        void Save();
    }
}
