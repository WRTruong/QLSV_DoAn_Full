using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class LopService
    {
        private readonly Model1 _db = new Model1();

        public List<Lop> GetAll() => _db.Lop.ToList();

        public Lop GetById(int maLop) => _db.Lop.Find(maLop);
        public List<Lop> GetByGiangVien(int maGV)
        {
            return _db.Lop.Where(l => l.MaGV == maGV).ToList();
        }


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
            var lop = _db.Lop.Find(maLop);
            if (lop == null) return false;
            _db.Lop.Remove(lop);
            _db.SaveChanges();
            return true;
        }
    }
}
