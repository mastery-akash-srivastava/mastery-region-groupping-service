﻿using System;
using System.Collections.Generic;

namespace Mastery.Region.Entity.Models
{
    public partial class SubregionRegion
    {
        public SubregionRegion()
        {
            ZipprefixSubregion = new HashSet<ZipprefixSubregion>();
        }

        public Guid Id { get; set; }
        public Guid? BatchInfoId { get; set; }
        public Guid? RegionId { get; set; }
        public string SubregionName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual BatchInfo BatchInfo { get; set; }
        public virtual RegionSuperRegion Region { get; set; }
        public virtual ICollection<ZipprefixSubregion> ZipprefixSubregion { get; set; }
    }
}
