using System;
using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class DiemService
    {
        private readonly Model1 _db = new Model1();

        // Tính điểm tổng an toàn với nullable double
        private float TinhDiemTong(double? diemQT, double? diemCK)
        {
            double qt = diemQT ?? 0;
            double ck = diemCK ?? 0;
            return (float)(qt * 0.4 + ck * 0.6);
        }

        // Lấy tất cả điểm (Admin)
        public List<Diem> GetAll()
        {
            return _db.Diem.ToList();
        }

        // Lấy điểm theo sinh viên
        public List<Diem> GetBySinhVien(int maSV)
        {
            return _db.Diem.Where(d => d.MaSV == maSV).ToList();
        }

        // Lấy điểm theo môn học của giảng viên dạy
        public List<Diem> GetByGiangVien(int maGV)
        {
            var dsMH = _db.LichHoc
                         .Where(lh => lh.MaGV == maGV)
                         .Select(lh => lh.MaMH)
                         .Distinct()
                         .ToList();

            return _db.Diem
                      .Where(d => dsMH.Contains(d.MaMH))
                      .ToList();
        }

        // Thêm hoặc cập nhật điểm (Admin hoặc Giảng viên sửa)
        public bool AddOrUpdate(Diem d)
        {
            try
            {
                var old = _db.Diem.Find(d.MaSV, d.MaMH);
                if (old == null)
                {
                    d.DiemTong = TinhDiemTong(d.DiemQT, d.DiemCK);
                    _db.Diem.Add(d);
                }
                else
                {
                    old.DiemQT = d.DiemQT;
                    old.DiemCK = d.DiemCK;
                    old.DiemTong = TinhDiemTong(old.DiemQT, old.DiemCK);
                }
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật điểm riêng lẻ theo Giảng viên
        public bool CapNhatDiemTheoGV(int maSV, int maMH, double? diemQT, double? diemCK)
        {
            try
            {
                var d = _db.Diem.Find(maSV, maMH);
                if (d == null) return false;

                d.DiemQT = diemQT;
                d.DiemCK = diemCK;
                d.DiemTong = TinhDiemTong(diemQT, diemCK);

                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa điểm
        public bool Delete(int maSV, int maMH)
        {
            var d = _db.Diem.Find(maSV, maMH);
            if (d == null) return false;

            _db.Diem.Remove(d);
            _db.SaveChanges();
            return true;
        }
    }
}
