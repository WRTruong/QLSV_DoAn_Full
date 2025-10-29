using System;
using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class ThongBaoService
    {
        private readonly Model1 _db = new Model1();

        public List<ThongBao> GetAll() => _db.ThongBao.ToList();

        public bool Add(ThongBao tb)
        {
            try
            {
                tb.NgayTB = DateTime.Now;
                _db.ThongBao.Add(tb);
                _db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
