using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreDICrud.Models;

public partial class CoreDiContext : DbContext
{
    public CoreDiContext()
    {
    }

    public CoreDiContext(DbContextOptions<CoreDiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCity> TblCities { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblState> TblStates { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCity>(entity =>
        {
            entity.HasKey(e => e.CityId);

            entity.ToTable("tblCity");

            entity.Property(e => e.City).HasMaxLength(50);

            entity.HasOne(d => d.State).WithMany(p => p.TblCities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_tblCity_tblState");
        });

        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId);

            entity.ToTable("tblCountry");

            entity.Property(e => e.Country).HasMaxLength(50);
        });

        modelBuilder.Entity<TblState>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("tblState");

            entity.Property(e => e.State).HasMaxLength(50);

            entity.HasOne(d => d.Country).WithMany(p => p.TblStates)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_tblState_tblCountry");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tblUser");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.EmailId).HasMaxLength(250);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(350);

            entity.HasOne(d => d.City).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_tblUser_tblCity");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
