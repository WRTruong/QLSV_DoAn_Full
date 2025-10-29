using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class KhoaService
    {
        private readonly Model1 _db = new Model1();

        public List<Khoa> GetAll() => _db.Khoa.ToList();

        public Khoa GetById(int maKhoa) => _db.Khoa.Find(maKhoa);

        public bool Add(Khoa khoa)
        {
            try { _db.Khoa.Add(khoa); _db.SaveChanges(); return true; }
            catch { return false; }
        }

        public bool Update(Khoa khoa)
        {
            var old = _db.Khoa.Find(khoa.MaKhoa);
            if (old == null) return false;
            old.TenKhoa = khoa.TenKhoa;
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int maKhoa)
        {
            var k = _db.Khoa.Find(maKhoa);
            if (k == null) return false;
            _db.Khoa.Remove(k);
            _db.SaveChanges();
            return true;
        }
    }
}
