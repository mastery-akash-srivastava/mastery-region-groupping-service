using System;
using System.Collections.Generic;

namespace Mastery.Region.Entity.Models
{
    public partial class SuperRegion
    {
        public SuperRegion()
        {
            RegionSuperRegion = new HashSet<RegionSuperRegion>();
        }

        public Guid Id { get; set; }
        public Guid? BatchInfoId { get; set; }
        public string SuperRegionName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual BatchInfo BatchInfo { get; set; }
        public virtual ICollection<RegionSuperRegion> RegionSuperRegion { get; set; }
    }
}
