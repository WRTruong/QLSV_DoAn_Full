using System;
using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class LogService
    {
        private readonly Model1 _db = new Model1();

        public void GhiLog(int maTK, string hanhDong, string bang, int? maLienQuan)
        {
            var log = new LogHoatDong
            {
                MaTK = maTK,
                HanhDong = hanhDong,
                BangLienQuan = bang,
                MaLienQuan = maLienQuan,
                ThoiGian = DateTime.Now
            };
            _db.LogHoatDong.Add(log);
            _db.SaveChanges();
        }

        public List<LogHoatDong> GetAll() =>
            _db.LogHoatDong.OrderByDescending(x => x.ThoiGian).ToList();

        public List<LogHoatDong> GetByTaiKhoan(int maTK) =>
            _db.LogHoatDong.Where(x => x.MaTK == maTK).OrderByDescending(x => x.ThoiGian).ToList();
    }
}
