using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.Data
{
    public class QLQKDbContext : DbContext 
    {
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<DatPhong> DatPhong { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<ChiTietKhuyenMai> ChiTietKhuyenMai { get; set; }
        public DbSet<KhuyenMai> KhuyenMai { get; set; }
        public DbSet<SuDungDichVu> SuDungDichVu { get; set; }
        public DbSet<ThanhToan> ThanhToan { get; set; }
        public DbSet<LoaiPhong> LoaiPhong { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( ConfigurationManager.ConnectionStrings["QLQKConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaiKhoan>()
                .HasOne(tk => tk.NhanVien)
                .WithOne(nv => nv.TaiKhoan)
                .HasForeignKey<TaiKhoan>(tk => tk.NhanVienID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
