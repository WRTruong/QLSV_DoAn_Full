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
        private readonly LichHocService lhService = new LichHocService();

        private SinhVien sinhVien;

        public frmSVHome(TaiKhoan tk)
        {
            InitializeComponent();
            _taiKhoan = tk;
        }

        private void frmSVHome_Load(object sender, EventArgs e)
        {
            if (!_taiKhoan.MaSV.HasValue)
            {
                MessageBox.Show("Tài khoản này chưa gán sinh viên!");
                this.Close();
                return;
            }

            sinhVien = svService.GetById(_taiKhoan.MaSV.Value);
            if (sinhVien == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                this.Close();
                return;
            }

            LoadThongTinCaNhan();
            LoadLichHoc();
            LoadMonHocDangKy();
            LoadDiem();
        }

        #region Thông tin cá nhân
        private void LoadThongTinCaNhan()
        {
            txtHoTen.Text = sinhVien.HoTen;
            txtDiaChi.Text = sinhVien.DiaChi;
            txtEmail.Text = sinhVien.Email;
            txtSDT.Text = sinhVien.SDT;
            txtQueQuan.Text = sinhVien.QueQuan;
            if (!string.IsNullOrEmpty(sinhVien.HinhAnh))
                pbHinhAnh.ImageLocation = sinhVien.HinhAnh;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
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
            var lich = (from dk in dkService.GetBySinhVien(sinhVien.MaSV)
                        join lh in lhService.GetAll()
                            on new { dk.MaMH, dk.MaHK } equals new { lh.MaMH, lh.MaHK }
                        select new
                        {
                            lh.Thu,
                            lh.TietBatDau,
                            lh.SoTiet,
                            TenMonHoc = lh.MonHoc != null ? lh.MonHoc.TenMH : "",
                            GiangVien = lh.GiangVien != null ? lh.GiangVien.HoTen : ""
                        }).ToList();

            dgvLichHoc.DataSource = lich;
        }
        #endregion

        #region Đăng ký môn học
        private void LoadMonHocDangKy()
        {
            // Lấy học kỳ hiện tại
            var hocKyHienTai = lhService.GetAll()
                                         .Select(l => l.HocKy)
                                         .OrderByDescending(hk => hk.MaHK)
                                         .FirstOrDefault();
            if (hocKyHienTai == null) return;

            var monHocChuaDangKy = dkService.GetMonHocChuaDangKy(sinhVien.MaSV);

            var ds = (from m in monHocChuaDangKy
                      join lh in lhService.GetAll()
                          on m.MaMH equals lh.MaMH
                      where lh.MaHK == hocKyHienTai.MaHK
                      select new
                      {
                          m.MaMH,
                          m.TenMH,
                          GiangVien = lh.GiangVien != null ? lh.GiangVien.HoTen : ""
                      }).ToList();

            dgvMonHoc.DataSource = ds;
        }

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;
            int maMH = (int)dgvMonHoc.CurrentRow.Cells["MaMH"].Value;

            if (dkService.DangKyMonHoc(sinhVien.MaSV, maMH))
            {
                MessageBox.Show("Đăng ký thành công!");
                LoadMonHocDangKy();
                LoadLichHoc();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }
        #endregion

        #region Xem điểm
        private void LoadDiem()
        {
            var diem = diemService.GetBySinhVien(sinhVien.MaSV);
            dgvDiem.DataSource = diem.Select(d => new
            {
                TenMonHoc = d.MonHoc != null ? d.MonHoc.TenMH : "",
                d.DiemQT,
                d.DiemCK,
                d.DiemTong
            }).ToList();
        }
        #endregion
    }
}
