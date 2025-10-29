using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSV.DAL
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<DangKyHoc> DangKyHoc { get; set; }
        public virtual DbSet<Diem> Diem { get; set; }
        public virtual DbSet<GiangVien> GiangVien { get; set; }
        public virtual DbSet<HocKy> HocKy { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<LichHoc> LichHoc { get; set; }
        public virtual DbSet<LogHoatDong> LogHoatDong { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<MonHoc> MonHoc { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThongBao> ThongBao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiangVien>()
                .HasMany(e => e.LichHoc)
                .WithRequired(e => e.GiangVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocKy>()
                .HasMany(e => e.DangKyHoc)
                .WithRequired(e => e.HocKy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocKy>()
                .HasMany(e => e.LichHoc)
                .WithRequired(e => e.HocKy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.Lop)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.LichHoc)
                .WithRequired(e => e.Lop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.DangKyHoc)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.Diem)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.LichHoc)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.TaiKhoan)
                .WithMany(e => e.Quyen)
                .Map(m => m.ToTable("TaiKhoan_Quyen").MapLeftKey("MaQuyen").MapRightKey("MaTK"));

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.DangKyHoc)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.Diem)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.LogHoatDong)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);
        }
    }
}
