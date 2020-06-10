using System;
using System.Collections.Generic;

namespace Mastery.Region.Entity.Models
{
    public partial class RegionSuperRegion
    {
        public RegionSuperRegion()
        {
            SubregionRegion = new HashSet<SubregionRegion>();
        }

        public Guid Id { get; set; }
        public Guid? BatchInfoId { get; set; }
        public string RegionName { get; set; }
        public Guid? SuperRegionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual BatchInfo BatchInfo { get; set; }
        public virtual SuperRegion SuperRegion { get; set; }
        public virtual ICollection<SubregionRegion> SubregionRegion { get; set; }
    }
}
