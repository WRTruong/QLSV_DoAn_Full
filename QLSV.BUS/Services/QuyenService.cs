using System.Collections.Generic;
using System.Linq;
using QLSV.DAL;

namespace QLSV.BUS.Services
{
    public class QuyenService
    {
        private readonly Model1 _db = new Model1();

        // Lấy tất cả quyền
        public List<Quyen> GetAll()
        {
            return _db.Quyen.ToList();
        }

        // Lấy danh sách quyền của một tài khoản
        public List<Quyen> GetByTaiKhoan(int maTK)
        {
            return _db.TaiKhoan
                .Where(tk => tk.MaTK == maTK)
                .SelectMany(tk => tk.Quyen)  // navigation property
                .ToList();
        }

        // Lấy danh sách tài khoản theo quyền
        public List<TaiKhoan> GetTaiKhoanByQuyen(int maQuyen)
        {
            return _db.Quyen
                .Where(q => q.MaQuyen == maQuyen)
                .SelectMany(q => q.TaiKhoan) // navigation property
                .ToList();
        }

        // Lấy danh sách quyền dưới dạng tên
        public List<string> GetTenQuyenByTaiKhoan(int maTK)
        {
            return _db.TaiKhoan
                .Where(tk => tk.MaTK == maTK)
                .SelectMany(tk => tk.Quyen)
                .Select(q => q.TenQuyen)
                .ToList();
        }
    }
}
