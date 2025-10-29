using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class DangKyHocService
    {
        private readonly Model1 _db = new Model1();

        public List<DangKyHoc> GetAll() => _db.DangKyHoc.ToList();

        public List<DangKyHoc> GetBySinhVien(int maSV) =>
            _db.DangKyHoc.Where(x => x.MaSV == maSV).ToList();

        public bool DangKy(DangKyHoc dk)
        {
            try
            {
                var exist = _db.DangKyHoc.Find(dk.MaSV, dk.MaMH, dk.MaHK);
                if (exist != null) return false;
                _db.DangKyHoc.Add(dk);
                _db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool HuyDangKy(int maSV, int maMH, int maHK)
        {
            var dk = _db.DangKyHoc.Find(maSV, maMH, maHK);
            if (dk == null) return false;
            _db.DangKyHoc.Remove(dk);
            _db.SaveChanges();
            return true;
        }
    }
}
