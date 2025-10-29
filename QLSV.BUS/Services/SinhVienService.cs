using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class SinhVienService
    {
        private readonly Model1 _db = new Model1();

        // 1. Lấy tất cả sinh viên
        public List<SinhVien> GetAll()
        {
            return _db.SinhVien.ToList();
        }

        // 2. Lấy sinh viên theo lớp
        public List<SinhVien> GetByLop(int maLop)
        {
            return _db.SinhVien.Where(sv => sv.MaLop == maLop).ToList();
        }

        // 3. Lấy sinh viên theo MaSV
        public SinhVien GetById(int maSV)
        {
            return _db.SinhVien.Find(maSV);
        }

        // 4. Thêm sinh viên mới
        public bool Add(SinhVien sv)
        {
            try
            {
                _db.SinhVien.Add(sv);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 5. Cập nhật sinh viên
        public bool Update(SinhVien sv)
        {
            var old = _db.SinhVien.Find(sv.MaSV);
            if (old == null) return false;

            old.HoTen = sv.HoTen;
            old.GioiTinh = sv.GioiTinh;
            old.NgaySinh = sv.NgaySinh;
            old.Email = sv.Email;
            old.SDT = sv.SDT;
            old.DiaChi = sv.DiaChi;
            old.QueQuan = sv.QueQuan;
            old.TonGiao = sv.TonGiao;
            old.HocLuc = sv.HocLuc;
            old.HocPhi = sv.HocPhi;
            old.TrangThai = sv.TrangThai;
            old.HinhAnh = sv.HinhAnh;
            old.MaLop = sv.MaLop;

            _db.SaveChanges();
            return true;
        }

        // 6. Xóa sinh viên
        public bool Delete(int maSV)
        {
            var sv = _db.SinhVien.Find(maSV);
            if (sv == null) return false;

            _db.SinhVien.Remove(sv);
            _db.SaveChanges();
            return true;
        }
    }
}
