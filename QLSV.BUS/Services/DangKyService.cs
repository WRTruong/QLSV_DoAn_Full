using System;
using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class DangKyHocService
    {
        private readonly Model1 _db = new Model1();

        // 1. Lấy tất cả đăng ký
        public List<DangKyHoc> GetAll() => _db.DangKyHoc.ToList();

        // 2. Lấy đăng ký theo sinh viên
        public List<DangKyHoc> GetBySinhVien(int maSV) =>
            _db.DangKyHoc.Where(x => x.MaSV == maSV).ToList();

        // 3. Lấy môn học chưa đăng ký
        public List<MonHoc> GetMonHocChuaDangKy(int maSV)
        {
            var dsDangKy = _db.DangKyHoc
                .Where(dh => dh.MaSV == maSV)
                .Select(dh => dh.MaMH)
                .ToList();
            return _db.MonHoc.Where(m => !dsDangKy.Contains(m.MaMH)).ToList();
        }

        // 4. Đăng ký môn học
        public bool DangKyMonHoc(int maSV, int MaMH)
        {
            try
            {
                var hocKyHienTai = _db.HocKy.OrderByDescending(hk => hk.MaHK).FirstOrDefault();
                if (hocKyHienTai == null) return false;

                var exist = _db.DangKyHoc
                    .FirstOrDefault(dh => dh.MaSV == maSV && dh.MaMH == MaMH && dh.MaHK == hocKyHienTai.MaHK);
                if (exist != null) return false;

                var dk = new DangKyHoc
                {
                    MaSV = maSV,
                    MaMH = MaMH,
                    MaHK = hocKyHienTai.MaHK
                };
                _db.DangKyHoc.Add(dk);
                _db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        // 5. Hủy đăng ký môn học
        public bool HuyDangKy(int maSV, int MaMH, int MaHK)
        {
            var dk = _db.DangKyHoc.Find(maSV, MaMH, MaHK);
            if (dk == null) return false;
            _db.DangKyHoc.Remove(dk);
            _db.SaveChanges();
            return true;
        }

        // 6. Lấy lịch học của sinh viên (join với LichHoc)
        public List<LichHoc> GetLichHocByMaSV(int maSV)
        {
            return (from dh in _db.DangKyHoc
                    join lh in _db.LichHoc on dh.MaMH equals lh.MaMH
                    where dh.MaSV == maSV
                    select lh).ToList();
        }
        public HocKy GetHocKyHienTai()
        {
            return _db.HocKy.OrderByDescending(hk => hk.MaHK).FirstOrDefault();
        }

        public List<LichHoc> GetAllLichHoc() => _db.LichHoc.ToList();

    }
}
