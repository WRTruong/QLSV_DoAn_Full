using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class MonHocService
    {
        private readonly Model1 _db = new Model1();

        public List<MonHoc> GetAll() => _db.MonHoc.ToList();

        public bool Add(MonHoc mh)
        {
            try
            {
                _db.MonHoc.Add(mh);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(MonHoc mh)
        {
            var old = _db.MonHoc.Find(mh.MaMH);
            if (old == null) return false;

            old.TenMH = mh.TenMH;
            old.SoTC = mh.SoTC;

            _db.SaveChanges();
            return true;
        }

        public bool Delete(int maMH)
        {
            var mh = _db.MonHoc.Find(maMH);
            if (mh == null) return false;

            _db.MonHoc.Remove(mh);
            _db.SaveChanges();
            return true;
        }
        public List<MonHoc> GetMonHocByGiangVien(int maGV)
        {
            return _db.LichHoc
                      .Where(lh => lh.MaGV == maGV)
                      .Select(lh => lh.MonHoc)
                      .Distinct()
                      .ToList();
        }
    }
}
