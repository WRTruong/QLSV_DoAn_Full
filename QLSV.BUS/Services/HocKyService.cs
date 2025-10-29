using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;


namespace QLSV.BUS.Services
{
    public class HocKyService
    {
        private readonly Model1 _db = new Model1();

        public List<HocKy> GetAll() => _db.HocKy.ToList();

        public bool Add(HocKy hk)
        {
            try { _db.HocKy.Add(hk); _db.SaveChanges(); return true; }
            catch { return false; }
        }

        public bool Update(HocKy hk)
        {
            var old = _db.HocKy.Find(hk.MaHK);
            if (old == null) return false;
            old.TenHK = hk.TenHK;
            old.NamHoc = hk.NamHoc;
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int maHK)
        {
            var hk = _db.HocKy.Find(maHK);
            if (hk == null) return false;
            _db.HocKy.Remove(hk);
            _db.SaveChanges();
            return true;
        }
    }
}
