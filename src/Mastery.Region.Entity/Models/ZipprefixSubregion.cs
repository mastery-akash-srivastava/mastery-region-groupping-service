using System;
using System.Collections.Generic;

namespace Mastery.Region.Entity.Models
{
    public partial class ZipprefixSubregion
    {
        public Guid Id { get; set; }
        public Guid? BatchInfoId { get; set; }
        public string ZipPrefix { get; set; }
        public Guid? SubregionId { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual BatchInfo BatchInfo { get; set; }
        public virtual SubregionRegion Subregion { get; set; }
    }
}
