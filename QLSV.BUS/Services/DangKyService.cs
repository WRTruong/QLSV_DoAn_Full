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
                .Include(dk => dk.MonHoc)
                .Include(dk => dk.HocKy)
                .Where(dk => dk.MaSV == maSV)
                .ToList();
        }

        // Lấy môn học chưa đăng ký của sinh viên theo học kỳ
        public List<MonHoc> GetMonHocChuaDangKy(int maSV, int maHK)
        {
            var dsDangKy = _db.DangKyHoc
                .Where(dh => dh.MaSV == maSV && dh.MaHK == maHK)
                .Select(dh => dh.MaMH)
                .ToList();

            var monHocHK = _db.LichHoc
                .Where(lh => lh.MaHK == maHK)
                .Select(lh => lh.MonHoc)
                .Distinct()
                .ToList();

            return monHocHK.Where(m => !dsDangKy.Contains(m.MaMH)).ToList();
        }
        // Lấy đăng ký theo quyền (Admin hoặc SinhVien)
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

                // ✅ Lấy tất cả đăng ký SV: cả đăng ký trực tiếp và Admin thêm (MaSV == maSV)
                return query.Where(dk =>
                       (dk.MaSV == maSV && dk.MaHK == maHK.Value) // đăng ký trực tiếp SV
                    ).ToList();
            }

            return new List<DangKyHoc>();
        }


        // Đăng ký môn học theo quyền
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
        // Lấy danh sách môn học sinh viên có thể đăng ký
        public List<MonHocDangKyDto> GetMonHocChoSinhVien(int maSV, int maHK)
        {
            var sv = _db.SinhVien.Find(maSV);
            if (sv == null) return new List<MonHocDangKyDto>();

            // Môn học trong LichHoc theo lớp và học kỳ
            var monLop = _db.LichHoc
                .Where(lh => lh.MaHK == maHK && lh.MaLop == sv.MaLop)
                .Select(lh => new MonHocDangKyDto
                {
                    MaMH = lh.MaMH,
                    TenMH = lh.MonHoc.TenMH,
                    DaDangKy = _db.DangKyHoc.Any(dk => dk.MaSV == maSV && dk.MaMH == lh.MaMH && dk.MaHK == maHK)
                })
                .Distinct()
                .ToList();

            // Các môn sinh viên đã đăng ký nhưng không có trong LichHoc (ví dụ admin thêm môn tự do)
            var monDangKy = _db.DangKyHoc
                .Where(dk => dk.MaSV == maSV && dk.MaHK == maHK)
                .Select(dk => new MonHocDangKyDto
                {
                    MaMH = dk.MaMH,
                    TenMH = dk.MonHoc.TenMH,
                    DaDangKy = true
                })
                .Where(m => !monLop.Any(l => l.MaMH == m.MaMH))
                .ToList();

            return monLop.Union(monDangKy).ToList();
        }

        // DTO
        public class MonHocDangKyDto
        {
            public int MaMH { get; set; }
            public string TenMH { get; set; }
            public bool DaDangKy { get; set; }
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
    }
}
