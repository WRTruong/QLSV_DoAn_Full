using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class ThongBaoService
    {
        private readonly Model1 _db = new Model1();

        public List<ThongBao> GetAll() => _db.ThongBao.ToList();

        public ThongBao GetById(int maTB) => _db.ThongBao.Find(maTB);

        public bool Add(ThongBao tb)
        {
            try
            {
                _db.ThongBao.Add(tb);
                _db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update(ThongBao tb)
        {
            var old = _db.ThongBao.Find(tb.MaTB);
            if (old == null) return false;
            old.TieuDe = tb.TieuDe;
            old.NoiDung = tb.NoiDung;
            old.NgayTB = tb.NgayTB;
            _db.SaveChanges();
            return true;
        }

        // ✅ Phương thức Delete
        public bool Delete(int maTB)
        {
            var tb = _db.ThongBao.Find(maTB);
            if (tb == null) return false;
            _db.ThongBao.Remove(tb);
            _db.SaveChanges();
            return true;
        }
    }
}
