using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmDangKyHoc : Form
    {
        private readonly DangKyHocService dkService = new DangKyHocService();
        private readonly MonHocService mhService = new MonHocService();
        private readonly LichHocService lhService = new LichHocService();
        private readonly HocKyService hkService = new HocKyService();

        private int currentMaSV;

        public frmDangKyHoc(int maSV)
        {
            InitializeComponent();
            currentMaSV = maSV;
            LoadMonHocCombo();
            LoadDangKy();
        }

        private void LoadMonHocCombo()
        {
            var hocKyHienTai = hkService.GetAll().OrderByDescending(hk => hk.MaHK).FirstOrDefault();
            if (hocKyHienTai == null) return;

            // Lấy các môn chưa đăng ký
            var monHocChuaDangKy = dkService.GetMonHocChuaDangKy(currentMaSV);

            // Join với LichHoc để lấy GiangVien
            var ds = (from m in monHocChuaDangKy
                      join lh in lhService.GetAll() on m.MaMH equals lh.MaMH
                      where lh.MaHK == hocKyHienTai.MaHK
                      select new
                      {
                          m.MaMH,
                          m.TenMH,
                          GiangVien = lh.GiangVien.HoTen
                      }).ToList();

            cboMonHoc.DataSource = ds;
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
        }

        private void LoadDangKy()
        {
            var hocKyHienTai = hkService.GetAll().OrderByDescending(hk => hk.MaHK).FirstOrDefault();
            if (hocKyHienTai == null) return;

            // Lấy các đăng ký của sinh viên trong học kỳ hiện tại
            var dsDangKy = (from dk in dkService.GetBySinhVien(currentMaSV)
                            join lh in lhService.GetAll() on new { dk.MaMH, dk.MaHK } equals new { lh.MaMH, lh.MaHK }
                            join gv in lhService.GetAll().Select(l => l.GiangVien) on lh.MaGV equals gv.MaGV
                            where dk.MaHK == hocKyHienTai.MaHK
                            select new
                            {
                                dk.MaMH,
                                TenMonHoc = dk.MonHoc.TenMH,
                                GiangVien = gv.HoTen
                            }).ToList();

            dgvDangKy.DataSource = dsDangKy;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMonHoc.SelectedValue == null) return;
            int maMH = (int)cboMonHoc.SelectedValue;

            if (dkService.DangKyMonHoc(currentMaSV, maMH))
            {
                MessageBox.Show("Đăng ký thành công!");
                LoadMonHocCombo();
                LoadDangKy();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvDangKy.CurrentRow == null) return;
            int maMH = (int)dgvDangKy.CurrentRow.Cells["MaMH"].Value;
            var hocKyHienTai = hkService.GetAll().OrderByDescending(hk => hk.MaHK).FirstOrDefault();
            if (hocKyHienTai == null) return;

            if (dkService.HuyDangKy(currentMaSV, maMH, hocKyHienTai.MaHK))
            {
                MessageBox.Show("Hủy đăng ký thành công!");
                LoadMonHocCombo();
                LoadDangKy();
            }
            else
            {
                MessageBox.Show("Hủy thất bại!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMonHocCombo();
            LoadDangKy();
        }
    }
}
