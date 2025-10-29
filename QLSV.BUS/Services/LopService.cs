using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class LopService
    {
        private readonly Model1 _db = new Model1();

        public List<Lop> GetAll() => _db.Lop.ToList();

        public List<Lop> GetByKhoa(int maKhoa) =>
            _db.Lop.Where(x => x.MaKhoa == maKhoa).ToList();

        public bool Add(Lop lop)
        {
            try { _db.Lop.Add(lop); _db.SaveChanges(); return true; }
            catch { return false; }
        }

        public bool Update(Lop lop)
        {
            var old = _db.Lop.Find(lop.MaLop);
            if (old == null) return false;
            old.TenLop = lop.TenLop;
            old.MaKhoa = lop.MaKhoa;
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int maLop)
        {
            var l = _db.Lop.Find(maLop);
            if (l == null) return false;
            _db.Lop.Remove(l);
            _db.SaveChanges();
            return true;
        }
    }
}
