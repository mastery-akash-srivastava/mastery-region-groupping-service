using System;
using System.Collections.Generic;

namespace Mastery.Region.Entity.Models
{
    public partial class BatchInfo
    {
        public BatchInfo()
        {
            RegionSuperRegion = new HashSet<RegionSuperRegion>();
            SubregionRegion = new HashSet<SubregionRegion>();
            SuperRegion = new HashSet<SuperRegion>();
            ZipprefixSubregion = new HashSet<ZipprefixSubregion>();
        }

        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Comment { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<RegionSuperRegion> RegionSuperRegion { get; set; }
        public virtual ICollection<SubregionRegion> SubregionRegion { get; set; }
        public virtual ICollection<SuperRegion> SuperRegion { get; set; }
        public virtual ICollection<ZipprefixSubregion> ZipprefixSubregion { get; set; }
    }
}
