using QLSV.BUS.Services;

namespace QLSV.BUS
{
    public static class ServiceFactory
    {
        public static readonly KhoaService Khoa = new KhoaService();
        public static readonly LopService Lop = new LopService();
        public static readonly SinhVienService SinhVien = new SinhVienService();
        public static readonly GiangVienService GiangVien = new GiangVienService();
        public static readonly MonHocService MonHoc = new MonHocService();
        public static readonly DiemService Diem = new DiemService();
        public static readonly HocKyService HocKy = new HocKyService();
        public static readonly DangKyHocService DangKy = new DangKyHocService();
        public static readonly TaiKhoanService TaiKhoan = new TaiKhoanService();
        public static readonly QuyenService Quyen = new QuyenService();
        public static readonly ThongBaoService ThongBao = new ThongBaoService();
        public static readonly LogService Log = new LogService();
        public static readonly LichHocService LichHoc = new LichHocService();
        public static readonly BaoCaoService BaoCao = new BaoCaoService();
    }
}
