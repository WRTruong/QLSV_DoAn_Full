using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;


namespace QLSV.BUS.Services
{
    public class GiangVienService
    {
        private readonly Model1 _db = new Model1();

        public List<GiangVien> GetAll() => _db.GiangVien.ToList();

        public GiangVien GetById(int maGV)
        {
            return _db.GiangVien.Find(maGV);
        }

        public bool Add(GiangVien gv)
        {
            try { _db.GiangVien.Add(gv); _db.SaveChanges(); return true; }
            catch { return false; }
        }

        public bool Update(GiangVien gv)
        {
            var old = _db.GiangVien.Find(gv.MaGV);
            if (old == null) return false;
            old.HoTen = gv.HoTen;
            old.ChuyenNganh = gv.ChuyenNganh;
            old.Email = gv.Email;
            old.DiaChi = gv.DiaChi;
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int maGV)
        {
            var gv = _db.GiangVien.Find(maGV);
            if (gv == null) return false;
            _db.GiangVien.Remove(gv);
            _db.SaveChanges();
            return true;
        }
    }
}
