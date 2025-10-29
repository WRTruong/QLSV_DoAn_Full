using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmSVHome : Form
    {
        private readonly TaiKhoan _taiKhoan;
        private readonly SinhVienService svService = new SinhVienService();
        private readonly DangKyHocService dkService = new DangKyHocService();
        private readonly DiemService diemService = new DiemService();

        private SinhVien sinhVien;

        public frmSVHome(TaiKhoan tk)
        {
            InitializeComponent();
            _taiKhoan = tk;
        }

        private void frmSVHome_Load(object sender, EventArgs e)
        {
            // Lấy thông tin sinh viên từ tài khoản
            sinhVien = svService.GetById(_taiKhoan.MaSV ?? 0);
            LoadThongTinCaNhan();
            LoadLichHoc();
            LoadMonHocDangKy();
            LoadDiem();
        }

        #region Thông tin cá nhân
        private void LoadThongTinCaNhan()
        {
            if (sinhVien == null) return;

            txtHoTen.Text = sinhVien.HoTen;
            txtDiaChi.Text = sinhVien.DiaChi;
            txtEmail.Text = sinhVien.Email;
            txtSDT.Text = sinhVien.SDT;
            txtQueQuan.Text = sinhVien.QueQuan;
            if (!string.IsNullOrEmpty(sinhVien.HinhAnh))
            {
                pbHinhAnh.ImageLocation = sinhVien.HinhAnh;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (sinhVien == null) return;

            sinhVien.DiaChi = txtDiaChi.Text;
            sinhVien.Email = txtEmail.Text;
            sinhVien.SDT = txtSDT.Text;

            if (svService.Update(sinhVien))
                MessageBox.Show("Cập nhật thông tin thành công!");
            else
                MessageBox.Show("Cập nhật thất bại!");
        }
        #endregion

        #region Lịch học
        private void LoadLichHoc()
        {
            if (sinhVien == null) return;

            var lich = dkService.GetLichHocByMaSV(sinhVien.MaSV);
            dgvLichHoc.DataSource = lich.Select(l => new
            {
                Lop = l.Lop?.TenLop,
                MonHoc = l.MonHoc?.TenMH,
                GiangVien = l.GiangVien?.HoTen,
                HocKy = l.HocKy?.TenHK,
                l.Thu,
                l.TietBatDau,
                l.SoTiet
            }).ToList();
        }
        #endregion

        #region Đăng ký môn học
        private void LoadMonHocDangKy()
        {
            if (sinhVien == null) return;

            var dsMH = dkService.GetMonHocChuaDangKy(sinhVien.MaSV);
            dgvMonHoc.DataSource = dsMH.Select(m => new
            {
                m.MaMH,
                m.TenMH,
                m.SoTC,
                GiangVien = m.GiangVien?.HoTen
            }).ToList();
        }

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;

            int maMH = (int)dgvMonHoc.CurrentRow.Cells["MaMH"].Value;
            bool kq = dkService.DangKyMonHoc(sinhVien.MaSV, maMH);
            if (kq)
            {
                MessageBox.Show("Đăng ký môn học thành công!");
                LoadMonHocDangKy();
                LoadLichHoc();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại hoặc đã đăng ký môn này!");
            }
        }
        #endregion

        #region Xem điểm
        private void LoadDiem()
        {
            if (sinhVien == null) return;

            var dsDiem = diemService.GetBySinhVien(sinhVien.MaSV);
            dgvDiem.DataSource = dsDiem.Select(d => new
            {
                MonHoc = d.MonHoc?.TenMH,
                d.DiemQT,
                d.DiemCK,
                d.DiemTong
            }).ToList();
        }
        #endregion
    }
}
