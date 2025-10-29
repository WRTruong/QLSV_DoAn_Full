using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;


namespace QLSV.BUS.Services
{
    public class DiemService
    {
        private readonly Model1 _db = new Model1();

        public List<Diem> GetAll() => _db.Diem.ToList();

        public List<Diem> GetBySinhVien(int maSV) =>
            _db.Diem.Where(d => d.MaSV == maSV).ToList();

        public bool AddOrUpdate(Diem d)
        {
            try
            {
                var old = _db.Diem.Find(d.MaSV, d.MaMH);
                if (old == null)
                {
                    d.DiemTong = (float)(d.DiemQT * 0.4 + d.DiemCK * 0.6);
                    _db.Diem.Add(d);
                }
                else
                {
                    old.DiemQT = d.DiemQT;
                    old.DiemCK = d.DiemCK;
                    old.DiemTong = (float)(d.DiemQT * 0.4 + d.DiemCK * 0.6);
                }
                _db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Delete(int maSV, int maMH)
        {
            var d = _db.Diem.Find(maSV, maMH);
            if (d == null) return false;
            _db.Diem.Remove(d);
            _db.SaveChanges();
            return true;
        }
    }
}
