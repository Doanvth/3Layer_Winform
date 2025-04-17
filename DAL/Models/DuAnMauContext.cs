using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class DuAnMauContext : DbContext
{
    public DuAnMauContext()
    {
    }

    public DuAnMauContext(DbContextOptions<DuAnMauContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DONNA\\SQLEXPRESS;Initial Catalog=DuAnMau;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA47ED285D28");

            entity.ToTable("NhanVien");

            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.TenDangNhap).HasMaxLength(50);

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaVaiTro)
                .HasConstraintName("FK__NhanVien__MaVaiT__398D8EEE");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6EDF0A4C6AC");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ImagePath).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.MaVaiTro).HasName("PK__VaiTro__C24C41CF64FB135A");

            entity.ToTable("VaiTro");

            entity.Property(e => e.TenVaiTro).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
