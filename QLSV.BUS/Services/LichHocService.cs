using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class LichHocService
    {
        private readonly Model1 _db = new Model1();

        public List<LichHoc> GetAll() => _db.LichHoc.ToList();

        public List<LichHoc> GetByLop(int maLop) =>
            _db.LichHoc.Where(x => x.MaLop == maLop).ToList();

        public bool Add(LichHoc lich)
        {
            try { _db.LichHoc.Add(lich); _db.SaveChanges(); return true; }
            catch { return false; }
        }

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
