using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class BaoCaoService
    {
        private readonly Model1 _db = new Model1();

        public object TongKetDiemTheoSinhVien(int maSV)
        {
            var data = from d in _db.Diem
                       join mh in _db.MonHoc on d.MaMH equals mh.MaMH
                       where d.MaSV == maSV
                       select new
                       {
                           mh.TenMH,
                           d.DiemQT,
                           d.DiemCK,
                           d.DiemTong
                       };
            return data.ToList();
        }

        public object TongKetLop(int maLop)
        {
            var data = from sv in _db.SinhVien
                       join d in _db.Diem on sv.MaSV equals d.MaSV
                       where sv.MaLop == maLop
                       group d by new { sv.MaSV, sv.HoTen } into g
                       select new
                       {
                           g.Key.MaSV,
                           g.Key.HoTen,
                           DiemTB = g.Average(x => x.DiemTong)
                       };
            return data.ToList();
        }
    }
}
