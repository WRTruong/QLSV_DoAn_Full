using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class LichHocService
    {
        private readonly Model1 _db = new Model1();

        // Lấy tất cả lịch học
        public List<LichHoc> GetAll()
        {
            return _db.LichHoc
                .Include(l => l.MonHoc)
                .Include(l => l.GiangVien)
                .Include(l => l.HocKy)
                .Include(l => l.Lop)
                .ToList();
        }

        // Lấy lịch học theo lớp
        public List<LichHoc> GetByLop(int maLop)
        {
            return _db.LichHoc
                .Include(lh => lh.MonHoc)
                .Include(lh => lh.GiangVien)
                .Include(lh => lh.HocKy)
                .Where(lh => lh.MaLop == maLop)
                .ToList();
        }

        // Lấy lịch học theo sinh viên (dựa vào lớp của sinh viên)
        public List<LichHoc> GetBySinhVien(int maSV)
        {
            var sv = _db.SinhVien.Find(maSV);
            if (sv == null || sv.MaLop == null) return new List<LichHoc>();

            return _db.LichHoc
                .Include(lh => lh.MonHoc)
                .Include(lh => lh.GiangVien)
                .Include(lh => lh.HocKy)
                .Where(lh => lh.MaLop == sv.MaLop)
                .ToList();
        }

        // Thêm lịch học mới
        public bool Add(LichHoc lich)
        {
            try
            {
                _db.LichHoc.Add(lich);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa lịch học
        public bool Delete(int maLop, int maMH, int maHK)
        {
            var lich = _db.LichHoc.Find(maLop, maMH, maHK);
            if (lich == null) return false;
            _db.LichHoc.Remove(lich);
            _db.SaveChanges();
            return true;
        }
    }
}
