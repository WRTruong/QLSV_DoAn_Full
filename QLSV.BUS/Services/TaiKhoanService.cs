using System.Linq;
using QLSV.DAL;


namespace QLSV.BUS.Services
{
    public class TaiKhoanService
    {
        private readonly Model1 _db = new Model1();

        public TaiKhoan DangNhap(string username, string password)
        {
            return _db.TaiKhoan.FirstOrDefault(t => t.Username == username && t.Password == password);
        }

        public bool DoiMatKhau(int maTK, string matKhauMoi)
        {
            var tk = _db.TaiKhoan.Find(maTK);
            if (tk == null) return false;
            tk.Password = matKhauMoi;
            _db.SaveChanges();
            return true;
        }

        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            try { _db.TaiKhoan.Add(tk); _db.SaveChanges(); return true; }
            catch { return false; }
        }

        public bool XoaTaiKhoan(int maTK)
        {
            var tk = _db.TaiKhoan.Find(maTK);
            if (tk == null) return false;
            _db.TaiKhoan.Remove(tk);
            _db.SaveChanges();
            return true;
        }
    }
}
