using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class DangKyHocService
    {
        private readonly Model1 _db = new Model1();

        // Lấy tất cả đăng ký (Admin)
        public List<DangKyHoc> GetAll()
        {
            return _db.DangKyHoc
                .Include(dk => dk.SinhVien)
                .Include(dk => dk.MonHoc)
                .Include(dk => dk.HocKy)
                .ToList();
        }

        // Lấy đăng ký theo sinh viên
        public List<DangKyHoc> GetBySinhVien(int maSV)
        {
            return _db.DangKyHoc
                .Include(dk => dk.SinhVien)
                .Include(dk => dk.MonHoc)
                .Include(dk => dk.HocKy)
                .Where(dk => dk.MaSV == maSV)
                .ToList();
        }

        // Lấy đăng ký theo quyền và học kỳ
        public List<DangKyHoc> GetDangKyTheoQuyen(string role, int? maSV = null, int? maHK = null)
        {
            var query = _db.DangKyHoc
                .Include(dk => dk.SinhVien)
                .Include(dk => dk.MonHoc)
                .Include(dk => dk.HocKy)
                .AsQueryable();

            role = role?.Trim();

            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                if (maHK.HasValue && maHK.Value > 0)
                    query = query.Where(dk => dk.MaHK == maHK.Value);
                return query.ToList();
            }

            if (role.Equals("SinhVien", StringComparison.OrdinalIgnoreCase) && maSV.HasValue)
            {
                if (!maHK.HasValue || maHK.Value <= 0)
                    maHK = _db.HocKy.OrderByDescending(hk => hk.MaHK).Select(hk => hk.MaHK).FirstOrDefault();

                return query.Where(dk => dk.MaSV == maSV && dk.MaHK == maHK.Value).ToList();
            }

            return new List<DangKyHoc>();
        }

        // Lấy môn học chưa đăng ký theo sinh viên và học kỳ
        public List<MonHoc> GetMonHocChuaDangKy(int maSV, int maHK)
        {
            if (maSV <= 0)
                return _db.MonHoc.ToList(); // admin: tất cả môn

            var dsDangKy = _db.DangKyHoc
                .Where(dh => dh.MaSV == maSV && dh.MaHK == maHK)
                .Select(dh => dh.MaMH)
                .ToList();

            // Chỉ lấy môn có lịch trong học kỳ đó
            var monHocHK = _db.LichHoc
                .Where(lh => lh.MaHK == maHK)
                .Select(lh => lh.MonHoc)
                .Distinct()
                .ToList();

            return monHocHK.Where(m => !dsDangKy.Contains(m.MaMH)).ToList();
        }

        // Đăng ký môn học
        public bool DangKyMonHocTheoQuyen(string role, int maSV, int maMH, int maHK)
        {
            try
            {
                if (maHK <= 0) return false;

                var exist = _db.DangKyHoc.FirstOrDefault(dh => dh.MaSV == maSV && dh.MaMH == maMH && dh.MaHK == maHK);
                if (exist != null) return false;

                var dk = new DangKyHoc
                {
                    MaSV = maSV,
                    MaMH = maMH,
                    MaHK = maHK
                };
                _db.DangKyHoc.Add(dk);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Hủy đăng ký
        public bool HuyDangKy(int maSV, int maMH, int maHK)
        {
            var dk = _db.DangKyHoc.Find(maSV, maMH, maHK);
            if (dk == null) return false;
            _db.DangKyHoc.Remove(dk);
            _db.SaveChanges();
            return true;
        }

        // Lấy học kỳ hiện tại
        public HocKy GetHocKyHienTai()
        {
            return _db.HocKy.OrderByDescending(hk => hk.MaHK).FirstOrDefault();
        }

        // Lấy tất cả lịch học
        public List<LichHoc> GetAllLichHoc()
        {
            return _db.LichHoc
                .Include(l => l.GiangVien)
                .Include(l => l.MonHoc)
                .Include(l => l.HocKy)
                .ToList();
        }
    }
}
