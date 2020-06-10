using Mastery.Region.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Mastery.Region.Entity
{
    public partial class MasteryRegionDbContext : DbContext
    {
        public MasteryRegionDbContext()
        {
        }

        public MasteryRegionDbContext(DbContextOptions<MasteryRegionDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BatchInfo> BatchInfo { get; set; }
        public virtual DbSet<RegionSuperRegion> RegionSuperRegion { get; set; }
        public virtual DbSet<SubregionRegion> SubregionRegion { get; set; }
        public virtual DbSet<SuperRegion> SuperRegion { get; set; }
        public virtual DbSet<ZipprefixSubregion> ZipprefixSubregion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=mastery_api_development;Username=postgres;Password=Emtec321");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum(null, "customer_credit_status_state", new[] { "Approved", "Pending", "Declined" })
                .HasPostgresExtension("citext")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("postgis");

            modelBuilder.Entity<BatchInfo>(entity =>
            {
                entity.ToTable("batch_info");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExpiryDate).HasColumnName("expiry_date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<RegionSuperRegion>(entity =>
            {
                entity.ToTable("region_super_region");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.BatchInfoId).HasColumnName("batch_info_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("character varying");

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasColumnName("region_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.SuperRegionId).HasColumnName("super_region_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.BatchInfo)
                    .WithMany(p => p.RegionSuperRegion)
                    .HasForeignKey(d => d.BatchInfoId)
                    .HasConstraintName("region_superregion_relationship_fkey_batch_info_id");

                entity.HasOne(d => d.SuperRegion)
                    .WithMany(p => p.RegionSuperRegion)
                    .HasForeignKey(d => d.SuperRegionId)
                    .HasConstraintName("region_superregion_relationship_fkey_super_region_id");
            });

            modelBuilder.Entity<SubregionRegion>(entity =>
            {
                entity.ToTable("subregion_region");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.BatchInfoId).HasColumnName("batch_info_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("character varying");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.SubregionName)
                    .IsRequired()
                    .HasColumnName("subregion_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.BatchInfo)
                    .WithMany(p => p.SubregionRegion)
                    .HasForeignKey(d => d.BatchInfoId)
                    .HasConstraintName("subregion_region_fkey_batch_info_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.SubregionRegion)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("subregion_region_fkey_region_id");
            });

            modelBuilder.Entity<SuperRegion>(entity =>
            {
                entity.ToTable("super_region");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.BatchInfoId).HasColumnName("batch_info_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("character varying");

                entity.Property(e => e.SuperRegionName)
                    .IsRequired()
                    .HasColumnName("super_region_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.BatchInfo)
                    .WithMany(p => p.SuperRegion)
                    .HasForeignKey(d => d.BatchInfoId)
                    .HasConstraintName("super_region_fkey_batch_info_id");
            });

            modelBuilder.Entity<ZipprefixSubregion>(entity =>
            {
                entity.ToTable("zipprefix_subregion");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.BatchInfoId).HasColumnName("batch_info_id");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("character varying");

                entity.Property(e => e.StateName)
                    .HasColumnName("state_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.SubregionId).HasColumnName("subregion_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasColumnType("character varying");

                entity.Property(e => e.ZipPrefix)
                    .IsRequired()
                    .HasColumnName("zip_prefix")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.BatchInfo)
                    .WithMany(p => p.ZipprefixSubregion)
                    .HasForeignKey(d => d.BatchInfoId)
                    .HasConstraintName("zipprefix_subregion_fkey_batch_info_id");

                entity.HasOne(d => d.Subregion)
                    .WithMany(p => p.ZipprefixSubregion)
                    .HasForeignKey(d => d.SubregionId)
                    .HasConstraintName("zipprefix_subregion_fkey_subregion_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
