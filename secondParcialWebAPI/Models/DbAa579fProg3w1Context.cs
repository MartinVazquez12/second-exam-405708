using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace secondParcialWebAPI.Models;

public partial class DbAa579fProg3w1Context : DbContext
{
    public DbAa579fProg3w1Context()
    {
    }

    public DbAa579fProg3w1Context(DbContextOptions<DbAa579fProg3w1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Deporte> Deportes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Socio> Socios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=socioDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Deporte>(entity =>
        {
            entity.ToTable("deportes");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("roles");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Socio>(entity =>
        {
            entity.ToTable("socios");

            entity.HasIndex(e => e.IdDeporte, "IX_socios_IdDeporte");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.IdDeporteNavigation).WithMany(p => p.Socios).HasForeignKey(d => d.IdDeporte);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("usuarios");

            entity.HasIndex(e => e.IdRol, "IX_usuarios_IdRol");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios).HasForeignKey(d => d.IdRol);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
