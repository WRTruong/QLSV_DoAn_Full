using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class SinhVienService
    {
        private readonly Model1 _db = new Model1();

        public List<SinhVien> GetAll() => _db.SinhVien.ToList();

        public List<SinhVien> GetByLop(int maLop) =>
            _db.SinhVien.Where(sv => sv.MaLop == maLop).ToList();

        public SinhVien GetById(int maSV) => _db.SinhVien.Find(maSV);

        // Thêm alias để tương thích code cũ
        public SinhVien GetByMaSV(int maSV) => GetById(maSV);

        public bool Add(SinhVien sv)
        {
            try { _db.SinhVien.Add(sv); _db.SaveChanges(); return true; }
            catch { return false; }
        }

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
