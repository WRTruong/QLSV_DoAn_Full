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
        private readonly LichHocService lhService = new LichHocService();
        private readonly HocKyService hkService = new HocKyService();
        private readonly SinhVienService svService = new SinhVienService();

        private readonly string userRole;
        private readonly int userMaSV;

        public frmDangKyHoc(string role, int maSV)
        {
            InitializeComponent();
            userRole = role;
            userMaSV = maSV;

            // Combo Sinh viên chỉ Admin thấy
            cboSinhVien.Visible = lblSinhVien.Visible = userRole == "Admin";

            LoadHocKy();
            LoadSinhVien();
            LoadMonHocCombo();
            LoadDangKy();

            cboHocKy.SelectedIndexChanged += (s, e) => { LoadMonHocCombo(); LoadDangKy(); };
            cboSinhVien.SelectedIndexChanged += (s, e) => { LoadMonHocCombo(); LoadDangKy(); };
        }

        private void LoadHocKy()
        {
            var dsHK = hkService.GetAll().OrderByDescending(hk => hk.MaHK).ToList();
            cboHocKy.DataSource = dsHK;
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "MaHK";
        }

        private void LoadSinhVien()
        {
            if (userRole != "Admin") return;

            var dsSV = svService.GetAll();
            cboSinhVien.DataSource = dsSV;
            cboSinhVien.DisplayMember = "HoTen";
            cboSinhVien.ValueMember = "MaSV";
        }

        private int GetSelectedSinhVien()
        {
            if (userRole == "Admin")
            {
                if (cboSinhVien.SelectedValue == null) return 0;
                if (int.TryParse(cboSinhVien.SelectedValue.ToString(), out int maSV))
                    return maSV;
                return 0;
            }
            return userMaSV;
        }

        private int GetSelectedHocKy()
        {
            if (cboHocKy.SelectedValue == null) return 0;
            if (int.TryParse(cboHocKy.SelectedValue.ToString(), out int maHK))
                return maHK;
            return 0;
        }

        private void LoadMonHocCombo()
        {
            int maSV = GetSelectedSinhVien();
            int maHK = GetSelectedHocKy();

            if (maSV == 0 || maHK == 0)
            {
                cboMonHoc.DataSource = null;
                return;
            }

            var monHocChuaDK = dkService.GetMonHocChuaDangKy(maSV, maHK)
                .Join(lhService.GetAll().Where(lh => lh.MaHK == maHK), m => m.MaMH, lh => lh.MaMH,
                      (m, lh) => new
                      {
                          m.MaMH,
                          m.TenMH,
                          GiangVien = lh.GiangVien != null ? lh.GiangVien.HoTen : "Chưa có GV"
                      }).ToList();

            cboMonHoc.DataSource = monHocChuaDK.Count > 0 ? monHocChuaDK : null;
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
        }

        private void LoadDangKy()
        {
            int maSV = GetSelectedSinhVien();
            int maHK = GetSelectedHocKy();

            var dsDangKy = dkService.GetDangKyTheoQuyen(userRole,
                userRole == "Admin" ? maSV : (int?)maSV,
                maHK);

            var lichHocHK = lhService.GetAll().Where(lh => maHK == 0 || lh.MaHK == maHK).ToList();

            var ds = (from dk in dsDangKy
                      join lh in lichHocHK on dk.MaMH equals lh.MaMH into lhGroup
                      from lh in lhGroup.DefaultIfEmpty()
                      select new
                      {
                          dk.MaSV,
                          TenSinhVien = dk.SinhVien?.HoTen ?? "N/A",
                          dk.MaMH,
                          TenMonHoc = dk.MonHoc?.TenMH ?? "N/A",
                          GiangVien = lh?.GiangVien?.HoTen ?? "N/A",
                          dk.MaHK
                      }).ToList();

            dgvDangKy.DataSource = ds.Count > 0 ? ds : null;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn môn học.");
                return;
            }

            int maSV = GetSelectedSinhVien();
            int maHK = GetSelectedHocKy();
            if (!int.TryParse(cboMonHoc.SelectedValue.ToString(), out int maMH))
            {
                MessageBox.Show("Môn học không hợp lệ.");
                return;
            }

            if (maSV == 0 || maMH == 0 || maHK == 0) return;

            if (dkService.DangKyMonHocTheoQuyen(userRole, maSV, maMH, maHK))
            {
                MessageBox.Show("Đăng ký thành công!");
                LoadMonHocCombo();
                LoadDangKy();
            }
            else
                MessageBox.Show("Đăng ký thất bại!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvDangKy.CurrentRow == null) return;

            if (!int.TryParse(dgvDangKy.CurrentRow.Cells["MaSV"].Value.ToString(), out int maSV) ||
                !int.TryParse(dgvDangKy.CurrentRow.Cells["MaMH"].Value.ToString(), out int maMH))
            {
                MessageBox.Show("Lấy dữ liệu từ bảng không hợp lệ.");
                return;
            }

            int maHK = GetSelectedHocKy();
            if (dkService.HuyDangKy(maSV, maMH, maHK))
            {
                MessageBox.Show("Hủy đăng ký thành công!");
                LoadMonHocCombo();
                LoadDangKy();
            }
            else
                MessageBox.Show("Hủy thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMonHocCombo();
            LoadDangKy();
        }
    }
}
